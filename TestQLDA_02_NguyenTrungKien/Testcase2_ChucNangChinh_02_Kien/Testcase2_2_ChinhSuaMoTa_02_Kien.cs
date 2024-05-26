
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace Webdriver_Trello_02_NguyenTrungKien.Testcase2_ChucNangChinh_02_NguyenTrungKien
{
    [TestFixture]
    public class Testcase2_2_ChinhSuaMoTa_02_Kien
    {
        private IWebDriver driver_02_kien;
        private WebDriverWait wait_02_kien;

        [SetUp]
        public void SetupTest_02_kien ( )
        {
            driver_02_kien = new ChromeDriver();
            driver_02_kien.Manage().Window.Maximize();
            driver_02_kien.Navigate().GoToUrl("https://trello.com/");

            wait_02_kien = new WebDriverWait(driver_02_kien, TimeSpan.FromSeconds(60));
        }

        private void DangNhapVaoTrello_02_kien ( )
        {
           
            var nutDangNhap_02_kien = wait_02_kien.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("a[data-uuid='MJFtCCgVhXrVl7v9HA7EH_login']")));
            nutDangNhap_02_kien.Click();

            
            var NhapEmail_02_kien = wait_02_kien.Until(ExpectedConditions.ElementIsVisible(By.Id("username")));
            NhapEmail_02_kien.SendKeys("2051010152kien@ou.edu.vn");

            
            var nutTiepTuc_02_kien = wait_02_kien.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("span.css-178ag6o")));
            nutTiepTuc_02_kien.Click();

            
            var NhapMatKhau_02_kien = wait_02_kien.Until(ExpectedConditions.ElementIsVisible(By.Id("password")));
            NhapMatKhau_02_kien.SendKeys("ntk205600");

            // Nhấn nút "Đăng nhập" 
            var nutGuiDangNhap_02_kien = wait_02_kien.Until(ExpectedConditions.ElementToBeClickable(By.Id("login-submit")));
            nutGuiDangNhap_02_kien.Click();
        }

        [Test]
        public void TestChinhSuaThe_DacTa_02_kien ( )
        {
            DangNhapVaoTrello_02_kien();

            var tenBang_02_kien = "Kiem Thu Website Trello";
            var Bang_02_kien = wait_02_kien.Until(ExpectedConditions.ElementIsVisible(By.XPath($"//div[@class='board-tile-details-name' and contains(@title,'{tenBang_02_kien}')]")));
            Bang_02_kien.Click();

            var theCanChinhSua_02_kien = wait_02_kien.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[contains(text(), 'Đặc tả')]")));
            theCanChinhSua_02_kien.Click();

            var nutChinhSuaMoTa_02_kien = wait_02_kien.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("a.js-description-fake-text-area")));
            nutChinhSuaMoTa_02_kien.Click();

            var VungNhapMoTa_02_kien = wait_02_kien.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#ak-editor-textarea")));
            VungNhapMoTa_02_kien.Click();
            VungNhapMoTa_02_kien.SendKeys("Thông tin đặc tả đã được chỉnh sửa.");

            var nutLuu_02_kien = wait_02_kien.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("button.confirm.js-save-edit")));
            nutLuu_02_kien.Click();

            try
            {
                wait_02_kien.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[contains(text(), 'Đặc tả')]")));
                Assert.Pass("Thẻ 'Đặc tả' đã được chỉnh sửa thành công.");
            }
            catch (WebDriverTimeoutException)
            {
                Assert.Fail("Không thể chỉnh sửa thẻ 'Đặc tả' hoặc có lỗi xảy ra khi chỉnh sửa.");
            }
        }

        [Test]
        public void TestChinhSuaThe_TestCase_02_kien ( )
        {
            DangNhapVaoTrello_02_kien();

            var tenBang_02_kien = "Kiem Thu Website Trello";
            var Bang_02_kien = wait_02_kien.Until(ExpectedConditions.ElementIsVisible(By.XPath($"//div[@class='board-tile-details-name' and contains(@title,'{tenBang_02_kien}')]")));

            if (Bang_02_kien != null)
            {
                Bang_02_kien.Click();

                var theCanChinhSua_02_kien = wait_02_kien.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[contains(text(), 'Test case')]")));
                theCanChinhSua_02_kien.Click();

                var nutChinhSuaMoTa_02_kien = wait_02_kien.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("a.js-description-fake-text-area")));
                nutChinhSuaMoTa_02_kien.Click();

                var VungNhapMoTa_02_kien = wait_02_kien.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#ak-editor-textarea")));
                VungNhapMoTa_02_kien.Click();
                VungNhapMoTa_02_kien.SendKeys("Thông tin Test case đã được chỉnh sửa.");

                var nutLuu_02_kien = wait_02_kien.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("button.confirm.js-save-edit")));
                nutLuu_02_kien.Click();

                try
                {
                    wait_02_kien.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[contains(text(), 'Test case')]")));
                    Assert.Pass("Thẻ 'Test case' đã được chỉnh sửa thành công.");
                }
                catch (WebDriverTimeoutException)
                {
                    Assert.Fail("Không thể chỉnh sửa thẻ 'Đặc tả' hoặc có lỗi xảy ra khi chỉnh sửa.");
                }
            }
            else
            {
                Assert.Fail("Không thể truy cập vào bảng để tạo thẻ.");
            }
        }

        [Test]
        public void TestChinhSuaThe_VietBaoCao_02_kien ( )
        {
            DangNhapVaoTrello_02_kien();

            var tenBang_02_kien = "Kiem Thu Website Trello";
            var Bang_02_kien = wait_02_kien.Until(ExpectedConditions.ElementIsVisible(By.XPath($"//div[@class='board-tile-details-name' and contains(@title,'{tenBang_02_kien}')]")));

            if (Bang_02_kien != null)
            {
                Bang_02_kien.Click();

                var theCanChinhSua_02_kien = wait_02_kien.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[contains(text(), 'Viết báo cáo')]")));
                theCanChinhSua_02_kien.Click();

                var nutChinhSuaMoTa_02_kien = wait_02_kien.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("a.js-description-fake-text-area")));
                nutChinhSuaMoTa_02_kien.Click();

                var VungNhapMoTa_02_kien = wait_02_kien.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#ak-editor-textarea")));
                VungNhapMoTa_02_kien.Click();
                VungNhapMoTa_02_kien.SendKeys("Thông tin Viết báo cáo đã được chỉnh sửa.");

                var nutLuu_02_kien = wait_02_kien.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("button.confirm.js-save-edit")));

                nutLuu_02_kien.Click();


                try
                {
                    wait_02_kien.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[contains(text(), 'Viết báo cáo')]")));
                    Assert.Pass("Thẻ 'Viết báo cáo' đã được chỉnh sửa thành công.");
                }
                catch (WebDriverTimeoutException)
                {
                    Assert.Fail("Không thể chỉnh sửa thẻ 'Viết báo cáo' hoặc có lỗi xảy ra khi chỉnh sửa.");
                }
            }
            else
            {
                Assert.Fail("Không thể truy cập vào bảng để tạo thẻ.");
            }
        }

        [TearDown]
        public void TeardownTest_02_kien ( )
        {
            System.Threading.Thread.Sleep(5000);
            driver_02_kien.Quit();
        }
    }
}
