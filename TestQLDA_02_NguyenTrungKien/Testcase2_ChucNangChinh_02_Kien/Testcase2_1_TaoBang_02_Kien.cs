
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;


namespace Webdriver_Trello_02_NguyenTrungKien.Testcase2_ChucNangChinh_02_NguyenTrungKien
{
    [TestFixture]
    public class Testcase2_1_TaoBang_02_Kien
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

        private void DangNhapVaoTrello_02_kien ( )
        {
            var nutDangNhap_02_kien = wait_02_kien.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("a[data-uuid='MJFtCCgVhXrVl7v9HA7EH_login']")));
            nutDangNhap_02_kien.Click();

         
            var NhapEmail_02_kien = wait_02_kien.Until(ExpectedConditions.ElementToBeClickable(By.Id("username")));
            NhapEmail_02_kien.SendKeys("2051010152kien@ou.edu.vn");

            var nutTiepTuc_02_kien = wait_02_kien.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("span.css-178ag6o")));
            nutTiepTuc_02_kien.Click();

           
            var NhapMatKhau_02_kien = wait_02_kien.Until(ExpectedConditions.ElementToBeClickable(By.Id("password")));
            NhapMatKhau_02_kien.SendKeys("ntk205600");

            
            var nutGuiDangNhap_02_kien = wait_02_kien.Until(ExpectedConditions.ElementToBeClickable(By.Id("login-submit")));
            nutGuiDangNhap_02_kien.Click();
        }

        [Test]
        public void TestTaoBangSauKhiDangNhap_02_kien ( )
        {
           
            DangNhapVaoTrello_02_kien();

           
            var nutTaoBangMoi_02_kien = wait_02_kien.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("div.board-tile.mod-add")));
            nutTaoBangMoi_02_kien.Click();

           
            var NhapTieuDeBang_02_kien = wait_02_kien.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("input[data-testid='create-board-title-input']")));
            NhapTieuDeBang_02_kien.SendKeys("Kiem Thu Website Trello");

           
            var nutTao_02_kien = wait_02_kien.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("button[data-testid='create-board-submit-button']")));
            nutTao_02_kien.Click();

            try
            {
               
                wait_02_kien.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("h1[data-testid='board-name-display']")));
                Assert.Pass("Đã chuyển đến trang tạo bảng mới và hiển thị tên bảng.");
            }
            catch (WebDriverTimeoutException)
            {
                Assert.Fail("Không thể chuyển đến trang tạo bảng mới hoặc không hiển thị tên bảng.");
            }
        }

        [Test]
        public void TestTaoTheSauKhiTaoBang_02_kien ( )
        {
            
            DangNhapVaoTrello_02_kien();

            var tenBang_02_kien = "Kiem Thu Website Trello"; 
            var Bang_02_kien = wait_02_kien.Until(ExpectedConditions.ElementExists(By.XPath($"//div[@class='board-tile-details-name' and contains(@title,'{tenBang_02_kien}')]")));

           
            if (Bang_02_kien != null)
            {
               
                Bang_02_kien.Click();

                
                var nutThemDanhSach_02_kien = wait_02_kien.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("button[data-testid='list-composer-button']")));
                nutThemDanhSach_02_kien.Click();

                
                var nutThemThe_02_kien = wait_02_kien.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("button[data-testid='list-add-card-button']")));
                nutThemThe_02_kien.Click();

                
                var NhapTieuDeThe_02_kien = wait_02_kien.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("textarea[data-testid='list-card-composer-textarea']")));
                NhapTieuDeThe_02_kien.SendKeys("Đặc tả");

               
                var nutThemTheSubmit_02_kien = wait_02_kien.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("button[data-testid='list-card-composer-add-card-button']")));
                nutThemTheSubmit_02_kien.Click();

                
                var NhapTieuDeThe1_02_kien = wait_02_kien.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("textarea[data-testid='list-card-composer-textarea']")));
                NhapTieuDeThe1_02_kien.SendKeys("Test case");

                
                var nutThemTheSubmit1_02_kien = wait_02_kien.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("button[data-testid='list-card-composer-add-card-button']")));
                nutThemTheSubmit1_02_kien.Click();

                
                var NhapTieuDeThe2_02_kien = wait_02_kien.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("textarea[data-testid='list-card-composer-textarea']")));
                NhapTieuDeThe2_02_kien.SendKeys("Viết báo cáo");

                
                var nutThemTheSubmit2_02_kien = wait_02_kien.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("button[data-testid='list-card-composer-add-card-button']")));
                nutThemTheSubmit2_02_kien.Click();

                try
                {
                    
                    wait_02_kien.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[@data-testid='card-name' and contains(text(),'Đặc Tả')]")));
                    wait_02_kien.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[@data-testid='card-name' and contains(text(),'Test Case')]")));
                    wait_02_kien.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[@data-testid='card-name' and contains(text(),'Viết Báo Cáo')]")));

                    
                    Assert.Pass("Tất cả các thẻ đã được tạo thành công.");
                }
                catch (WebDriverTimeoutException)
                {
                    
                    Assert.Fail("Không thể tạo hoặc không thể tìm thấy tất cả các thẻ đã tạo.");
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
