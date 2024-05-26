using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace TestTrello_02_NguyenTrungKien.UnitTest_Trello_02_Kien
{
    [TestFixture]
    public class Testlogin_02_Kien
    {
        private IWebDriver driver_02_kien;
        private WebDriverWait wait_02_kien;

        [SetUp]
        public void SetupTest_02_Kien ( )
        {
            driver_02_kien = new ChromeDriver();
            driver_02_kien.Manage().Window.Maximize();
            driver_02_kien.Navigate().GoToUrl("https://trello.com/");

            wait_02_kien = new WebDriverWait(driver_02_kien, TimeSpan.FromSeconds(30));
        }

        [Test]
        public void Kiem_tra_dang_nhap_voi_thong_tin_hop_le_02_Kien ( )
        {

            string email_02_kien = "2051010152kien@ou.edu.vn";
            string password_02_kien = "ntk205600";


            Thuc_hien_dang_nhap(email_02_kien, password_02_kien);


            Assert.IsTrue(Dang_nhap_thanh_cong_02_kien(), "Dang nhap thanh cong voi thong tin dang nhap hop le.");
        }


        [Test]
        public void Kiem_tra_dang_nhap_voi_thong_tin_khong_hop_le_02_Kien ( )
        {

            string email_02_kien = "dytdytdy@yahoo.com";
            string password_02_kien = "111";


            Thuc_hien_dang_nhap(email_02_kien, password_02_kien);


            Assert.IsFalse(Dang_nhap_thanh_cong_02_kien(), "Dang nhap thanh cong voi thong tin dang nhap khong hop le.");
        }

        [Test]
        public void Kiem_tra_dang_nhap_voi_email_dung_nhung_mat_khau_sai_02_Kien ( )
        {

            string email_02_kien = "2051010152kien@ou.edu.vn";
            string password_02_kien = "ntkiennguyen";


            Thuc_hien_dang_nhap(email_02_kien, password_02_kien);


            Assert.IsFalse(Dang_nhap_thanh_cong_02_kien(), "Dang nhap thanh cong voi mat khau khong chinh xac.");
        }

        [Test]
        public void Kiem_tra_dang_nhap_voi_email_sai_nhung_mat_khau_dung_02_Kien ( )
        {

            string email_02_kien = "ntk205600@gmail.com";
            string password_02_kien = "ntk205600";


            Thuc_hien_dang_nhap(email_02_kien, password_02_kien);


            Assert.IsFalse(Dang_nhap_thanh_cong_02_kien(), "Dang nhap thanh cong voi ten dang nhap khong chinh xac.");
        }

        [TearDown]
        public void TeardownTest_02_Kien ( )
        {
            driver_02_kien.Quit();
        }

        private void Thuc_hien_dang_nhap ( string email, string password )
        {
            try
            {
                var nutDangNhap = wait_02_kien.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("a[data-uuid='MJFtCCgVhXrVl7v9HA7EH_login']")));
                nutDangNhap.Click();


                if (!string.IsNullOrEmpty(email))
                {
                    var oNhapEmail = wait_02_kien.Until(ExpectedConditions.ElementIsVisible(By.Id("username")));
                    oNhapEmail.SendKeys(email);
                }


                if (!string.IsNullOrEmpty(password))
                {
                    var nutTiepTuc = wait_02_kien.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("span.css-178ag6o")));
                    nutTiepTuc.Click();

                    var oNhapMatKhau = wait_02_kien.Until(ExpectedConditions.ElementIsVisible(By.Id("password")));
                    oNhapMatKhau.SendKeys(password);

                    var nutGuiDangNhap = wait_02_kien.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("span.css-178ag6o")));
                    nutGuiDangNhap.Click();
                }


                System.Threading.Thread.Sleep(2000);
            }
            catch (WebDriverTimeoutException)
            {

                return;
            }
        }

        private bool Dang_nhap_thanh_cong_02_kien ( )
        {
            try
            {
                var loiForm_02_kien = driver_02_kien.FindElement(By.CssSelector("section[data-testid='form-error']"));
                var thongBaoLoi_02_kien = loiForm_02_kien.FindElement(By.CssSelector("span.css-xal9c7")).Text;


                if (thongBaoLoi_02_kien.Contains("Địa chỉ email và/hoặc mật khẩu không chính xác"))
                {
                    return false;
                }
            }
            catch (NoSuchElementException)
            {

                if (driver_02_kien.Url != "https://trello.com/login" && driver_02_kien.Url != "https://trello.com/")
                {

                    try
                    {
                        var loiMatKhau_02_kien = driver_02_kien.FindElement(By.CssSelector("#password-uid3-error"));
                        var thongBaoLoiMatKhau_02_kien = loiMatKhau_02_kien.FindElement(By.CssSelector("span#password-error")).Text;

                        if (thongBaoLoiMatKhau_02_kien.Contains("Nhập mật khẩu"))
                        {
                            return false;
                        }
                    }
                    catch (NoSuchElementException)
                    {
                        return true;
                    }
                }
            }


            return false;
        }
    }
}
