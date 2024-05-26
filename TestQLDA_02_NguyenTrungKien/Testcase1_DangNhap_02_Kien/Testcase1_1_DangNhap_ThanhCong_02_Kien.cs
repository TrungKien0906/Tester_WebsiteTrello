using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;


namespace TestTrello_02_NguyenTrungKien.Testcase1_1_DangNhap_ThanhCong_02_Kien
{
    [TestFixture]
    public class Testcase1_1_DangNhap_ThanhCong_02_Kien
    {
        private IWebDriver driver_02_kien;
        private WebDriverWait wait_02_kien;

        [SetUp]
        public void Setup_02_kien ( )
        {
            driver_02_kien = new ChromeDriver();
            driver_02_kien.Manage().Window.Maximize();
            driver_02_kien.Navigate().GoToUrl("https://trello.com/");

            wait_02_kien = new WebDriverWait(driver_02_kien, TimeSpan.FromSeconds(30));
        }

        [Test]
        public void TestDangNhapBangID_02_kien ( )
        {
            var BtnDangNhap_02_kien = driver_02_kien.FindElement(By.CssSelector("a[data-uuid='MJFtCCgVhXrVl7v9HA7EH_login']"));
            BtnDangNhap_02_kien.Click();

            var NhapEmail_02_kien = wait_02_kien.Until(ExpectedConditions.ElementIsVisible(By.Id("username")));
            NhapEmail_02_kien.SendKeys("2051010152kien@ou.edu.vn");

            var BtnTieptuc_02_kien = wait_02_kien.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("span.css-178ag6o")));
            BtnTieptuc_02_kien.Click();

            var NhapMatkhau_02_kien = wait_02_kien.Until(ExpectedConditions.ElementIsVisible(By.Id("password")));
            NhapMatkhau_02_kien.SendKeys("ntk205600");

            var BtnSubmitDangNhap_02_kien = wait_02_kien.Until(ExpectedConditions.ElementToBeClickable(By.Id("login-submit")));
            BtnSubmitDangNhap_02_kien.Click();

            try
            {
                var thongbaothanhcong_02_kien = wait_02_kien.Until(ExpectedConditions.ElementExists(By.CssSelector(".DweEFaF5owOe02")));
                Assert.Pass("Đăng nhập thành công!");
            }
            catch (NoSuchElementException)
            {
                Assert.Fail("Đăng nhập không thành công!");
            }
        }

        [Test]
        public void TestDangNhapBangName_02_kien ( )
        {
            var BtnDangNhap_02_kien = driver_02_kien.FindElement(By.CssSelector("a[data-uuid='MJFtCCgVhXrVl7v9HA7EH_login']"));
            BtnDangNhap_02_kien.Click();

            var NhapEmail_02_kien = wait_02_kien.Until(ExpectedConditions.ElementIsVisible(By.Name("username")));
            NhapEmail_02_kien.SendKeys("2051010152kien@ou.edu.vn");

            var BtnTieptuc_02_kien = wait_02_kien.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("span.css-178ag6o")));
            BtnTieptuc_02_kien.Click();

            var NhapMatkhau_02_kien = wait_02_kien.Until(ExpectedConditions.ElementIsVisible(By.Name("password")));
            NhapMatkhau_02_kien.SendKeys("ntk205600");

            var BtnSubmitDangNhap_02_kien = wait_02_kien.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("span.css-178ag6o")));
            BtnSubmitDangNhap_02_kien.Click();

            try
            {
                var thongbaothanhcong_02_kien = wait_02_kien.Until(ExpectedConditions.ElementExists(By.CssSelector(".DweEFaF5owOe02")));
                Assert.Pass("Đăng nhập thành công!");
            }
            catch (NoSuchElementException)
            {
                Assert.Fail("Đăng nhập không thành công!");
            }
        }

        [Test]
        public void TestDangNhapBangXPath_02_kien ( )
        {
            var BtnDangNhap_02_kien = wait_02_kien.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id='BXP-APP']/header[1]/div/div[1]/div[2]/a[1]")));
            BtnDangNhap_02_kien.Click();

            var NhapEmail_02_kien = wait_02_kien.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='username']")));
            NhapEmail_02_kien.SendKeys("2051010152kien@ou.edu.vn");

            var BtnTieptuc_02_kien = wait_02_kien.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id='login-submit']/span")));
            BtnTieptuc_02_kien.Click();

            var NhapMatkhau_02_kien = wait_02_kien.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='password']")));
            NhapMatkhau_02_kien.SendKeys("ntk205600");

            var BtnSubmitDangNhap_02_kien = wait_02_kien.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id='login-submit']/span")));
            BtnSubmitDangNhap_02_kien.Click();

            try
            {
                var thongbaothanhcong_02_kien = wait_02_kien.Until(ExpectedConditions.ElementExists(By.CssSelector(".DweEFaF5owOe02")));
                Assert.Pass("Đăng nhập thành công!");
            }
            catch (NoSuchElementException)
            {
                Assert.Fail("Đăng nhập không thành công!");
            }
        }
        [Test]
        public void TestDangNhapBangClassName_02_kien ( )
        {
            var BtnDangNhap_02_kien = wait_02_kien.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(".Buttonsstyles__Button-sc-1jwidxo-0.kTwZBr")));
            BtnDangNhap_02_kien.Click();

            var NhapEmail_02_kien = wait_02_kien.Until(ExpectedConditions.ElementIsVisible(By.ClassName("css-1cab8vv")));
            NhapEmail_02_kien.SendKeys("2051010152kien@ou.edu.vn");

            var BtnTieptuc = wait_02_kien.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("#login-submit")));
             BtnTieptuc.Click();

            var NhapMatkhau_02_kien = wait_02_kien.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#password")));
            NhapMatkhau_02_kien.SendKeys("ntk205600");

            var BtnSubmitDangNhap_02_kien = wait_02_kien.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("#login-submit")));
            BtnSubmitDangNhap_02_kien.Click();

            try
            {
                var thongbaothanhcong_02_kien = wait_02_kien.Until(ExpectedConditions.ElementExists(By.CssSelector(".DweEFaF5owOe02")));
                Assert.Pass("Đăng nhập thành công!");
            }
            catch (NoSuchElementException)
            {
                Assert.Fail("Đăng nhập không thành công!");
            }
        }



        [Test]
        public void TestDangNhapBangCSSSelector_02_kien ( )
        {
            var BtnDangNhap_02_kien = wait_02_kien.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("a[data-uuid='MJFtCCgVhXrVl7v9HA7EH_login']")));
            BtnDangNhap_02_kien.Click();

            var NhapEmail_02_kien = wait_02_kien.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#username")));
            NhapEmail_02_kien.SendKeys("2051010152kien@ou.edu.vn");

            var BtnTieptuc_02_kien = wait_02_kien.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("span.css-178ag6o")));
            BtnTieptuc_02_kien.Click();

            var NhapMatkhau_02_kien = wait_02_kien.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#password")));
            NhapMatkhau_02_kien.SendKeys("ntk205600");

            var BtnSubmitDangNhap_02_kien = wait_02_kien.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("span.css-178ag6o")));
            BtnSubmitDangNhap_02_kien.Click();

            try
            {
                var thongbaothanhcong = wait_02_kien.Until(ExpectedConditions.ElementExists(By.CssSelector(".DweEFaF5owOe02")));
                Assert.Pass("Đăng nhập thành công!");
            }
            catch (NoSuchElementException)
            {
                Assert.Fail("Đăng nhập không thành công!");
            }
        }

        [Test]
        public void TestResetPasswordBangId_02_Kien ( )
        {
            var BtnDangNhap_02_kien = wait_02_kien.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("a[data-uuid='MJFtCCgVhXrVl7v9HA7EH_login']")));
            BtnDangNhap_02_kien.Click();

            var LinkResetPass_02_kien = wait_02_kien.Until(ExpectedConditions.ElementToBeClickable(By.Id("resetPassword")));
            LinkResetPass_02_kien.Click();

            var NhapEmail_02_kien = wait_02_kien.Until(ExpectedConditions.ElementIsVisible(By.Id("email")));
            NhapEmail_02_kien.SendKeys("2051010152kien@ou.edu.vn");

            var BtnTieptuc = wait_02_kien.Until(ExpectedConditions.ElementToBeClickable(By.Id("reset-password-email-submit")));
            BtnTieptuc.Click();

            if (driver_02_kien.Url.Contains("/login/resetpassword"))
            {
                Assert.Pass("Chức năng 'Bạn không đăng nhập được?' hoạt động chính xác.");
            }
            else
            {
                Assert.Fail("Không thể truy cập trang đặt lại mật khẩu.");
            }

        }

        [Test]
        public void TestResetPasswordBangLinkText_02_kien ( )
        {
            var BtnDangNhap_02_kien = wait_02_kien.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("a[data-uuid='MJFtCCgVhXrVl7v9HA7EH_login']")));
            BtnDangNhap_02_kien.Click();

            var resetPasswordLink_02_kien = wait_02_kien.Until(ExpectedConditions.ElementToBeClickable(By.LinkText("Can't log in?")));
            resetPasswordLink_02_kien.Click();

            var NhapEmail_02_kien = wait_02_kien.Until(ExpectedConditions.ElementIsVisible(By.Id("email")));
            NhapEmail_02_kien.SendKeys("2051010152kien@ou.edu.vn");

            var btnTieptuc_02_kien = wait_02_kien.Until(ExpectedConditions.ElementToBeClickable(By.Id("reset-password-email-submit")));
            btnTieptuc_02_kien.Click();

            if (driver_02_kien.Url.Contains("/login/resetpassword"))
            {
                Assert.Pass("Chức năng 'Bạn không đăng nhập được?' hoạt động chính xác.");
            }
            else
            {
                Assert.Fail("Không thể truy cập trang đặt lại mật khẩu.");
            }

        }

        [TearDown]
        public void TeardownTest_02_Kien ( )
        {
            System.Threading.Thread.Sleep(5000);
            driver_02_kien.Quit();
        }
    }
}
