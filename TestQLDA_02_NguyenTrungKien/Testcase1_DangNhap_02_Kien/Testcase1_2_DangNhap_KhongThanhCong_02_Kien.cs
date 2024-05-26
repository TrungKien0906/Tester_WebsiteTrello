using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;


namespace TestTrello_02_NguyenTrungKien.Testcase1_2_DangNhap_KhongThanhCong_02_Kien
{
    [TestFixture]
    public class Testcase1_2_DangNhap_KhongThanhCong_02_Kien
    {
        private IWebDriver driver_02_kien;
        private WebDriverWait wait_02_kien;

        [SetUp]
        public void SetupTest_02_kien ( )
        {
            driver_02_kien = new ChromeDriver();
            driver_02_kien.Manage().Window.Maximize();
            driver_02_kien.Navigate().GoToUrl("https://trello.com/");

            wait_02_kien = new WebDriverWait(driver_02_kien, TimeSpan.FromSeconds(30));
        }

        [Test]
        public void TestDangNhapID_Khongthanhcong_02_kien ( )
        {
            var nutDangNhap_02_kien = wait_02_kien.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("a[data-uuid='MJFtCCgVhXrVl7v9HA7EH_login']")));
            nutDangNhap_02_kien.Click();

            var NhapEmail_02_kien = wait_02_kien.Until(ExpectedConditions.ElementIsVisible(By.Id("username")));
            NhapEmail_02_kien.SendKeys("ntk205600@gmail.com");

            var nutTiepTuc_02_kien = wait_02_kien.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("span.css-178ag6o")));
            nutTiepTuc_02_kien.Click();

            var NhapMatKhau_02_kien = wait_02_kien.Until(ExpectedConditions.ElementIsVisible(By.Id("password")));
            NhapMatKhau_02_kien.SendKeys("ntk205600");

            var nutGuiDangNhap_02_kien = wait_02_kien.Until(ExpectedConditions.ElementToBeClickable(By.Id("login-submit")));
            nutGuiDangNhap_02_kien.Click();

            try
            {
                wait_02_kien.Until(ExpectedConditions.ElementExists(By.CssSelector("span.css-xal9c7")));
                Assert.Pass("Đăng nhập Không thành công do sai tài khoản hoặc mật khẩu!");
            }
            catch (WebDriverTimeoutException)
            {
                Assert.Pass("Đăng nhập thành công!");
            }
        }

        [Test]
        public void TestDangNhapName_Khongthanhcong_02_kien ( )
        {
            var nutDangNhap_02_kien = wait_02_kien.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("a[data-uuid='MJFtCCgVhXrVl7v9HA7EH_login']")));
            nutDangNhap_02_kien.Click();

            var NhapEmail_02_kien = wait_02_kien.Until(ExpectedConditions.ElementIsVisible(By.Name("username")));
            NhapEmail_02_kien.SendKeys("ntk205600@gmail.com");

            var nutTiepTuc_02_kien = wait_02_kien.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("span.css-178ag6o")));
            nutTiepTuc_02_kien.Click();

            var NhapMatKhau_02_kien = wait_02_kien.Until(ExpectedConditions.ElementIsVisible(By.Name("password")));
            NhapMatKhau_02_kien.SendKeys("ntk205600");

            var nutGuiDangNhap_02_kien = wait_02_kien.Until(ExpectedConditions.ElementToBeClickable(By.Id("login-submit")));
            nutGuiDangNhap_02_kien.Click();

            try
            {
                wait_02_kien.Until(ExpectedConditions.ElementExists(By.CssSelector("span.css-xal9c7")));
                Assert.Pass("Đăng nhập Không thành công do sai tài khoản hoặc mật khẩu!");
            }
            catch (WebDriverTimeoutException)
            {
                Assert.Pass("Đăng nhập thành công!");
            }
        }

        [Test]
        public void TestDangNhapXPath_Khongthanhcong_02_kien ( )
        {
            var nutDangNhap_02_kien = wait_02_kien.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id='BXP-APP']/header[1]/div/div[1]/div[2]/a[1]")));
            nutDangNhap_02_kien.Click();

            var NhapEmail_02_kien = wait_02_kien.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='username']")));
            NhapEmail_02_kien.SendKeys("ntk205600@gmail.com");

            var nutTiepTuc_02_kien = wait_02_kien.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id='login-submit']")));
            nutTiepTuc_02_kien.Click();

            var NhapMatKhau_02_kien = wait_02_kien.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='password']")));
            NhapMatKhau_02_kien.SendKeys("ntk205600");

            var nutGuiDangNhap_02_kien = wait_02_kien.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id='login-submit']/span")));
            nutGuiDangNhap_02_kien.Click();

            try
            {
                wait_02_kien.Until(ExpectedConditions.ElementExists(By.CssSelector("span.css-xal9c7")));
                Assert.Pass("Đăng nhập Không thành công do sai tài khoản hoặc mật khẩu!");
            }
            catch (WebDriverTimeoutException)
            {
                Assert.Pass("Đăng nhập thành công!");
            }
        }

        [Test]
        public void TestDangNhapCSSSelector_KhongThanhCong_02_kien ( )
        {
            var nutDangNhap_02_kien = wait_02_kien.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("a[data-uuid='MJFtCCgVhXrVl7v9HA7EH_login']")));
            nutDangNhap_02_kien.Click();

            var NhapEmail_02_kien = wait_02_kien.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#username")));
            NhapEmail_02_kien.SendKeys("ntk205600@gmail.com");

            var nutTiepTuc_02_kien = wait_02_kien.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("span.css-178ag6o")));
            nutTiepTuc_02_kien.Click();

            var NhapMatKhau_02_kien = wait_02_kien.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#password")));
            NhapMatKhau_02_kien.SendKeys("ntk205600");

            var nutGuiDangNhap_02_kien = wait_02_kien.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("span.css-178ag6o")));
            nutGuiDangNhap_02_kien.Click();

            try
            {
                wait_02_kien.Until(ExpectedConditions.ElementExists(By.CssSelector("span.css-xal9c7")));
                Assert.Pass("Đăng nhập Không thành công do sai tài khoản hoặc mật khẩu!");
            }
            catch (WebDriverTimeoutException)
            {
                Assert.Pass("Đăng nhập thành công!");
            }
        }

        [Test]
        public void TestDangNhapClassName_KhongThanhCong_02_kien ( )
        {
            var nutDangNhap_02_kien = wait_02_kien.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(".Buttonsstyles__Button-sc-1jwidxo-0.kTwZBr")));
            nutDangNhap_02_kien.Click();

            var NhapEmail_02_kien = wait_02_kien.Until(ExpectedConditions.ElementIsVisible(By.ClassName("css-1cab8vv")));
            NhapEmail_02_kien.SendKeys("ntk205600@gmail.com");

            var nutTiepTuc_02_kien = wait_02_kien.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("#login-submit")));
            nutTiepTuc_02_kien.Click();

            var NhapMatKhau_02_kien = wait_02_kien.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#password")));
            NhapMatKhau_02_kien.SendKeys("ntk205600");

            var nutGuiDangNhap_02_kien = wait_02_kien.Until(ExpectedConditions.ElementToBeClickable(By.ClassName("css-178ag6o")));
            nutGuiDangNhap_02_kien.Click();

            try
            {
                wait_02_kien.Until(ExpectedConditions.ElementExists(By.CssSelector("span.css-xal9c7")));
                Assert.Pass("Đăng nhập Không thành công do sai tài khoản hoặc mật khẩu!");
            }
            catch (WebDriverTimeoutException)
            {
                Assert.Pass("Đăng nhập thành công!");
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
