
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;


namespace Webdriver_Trello_02_NguyenTrungKien.Testcase2_ChucNangChinh_02_NguyenTrungKien
{
    [TestFixture]
    public class Testcase2_3_ThemCongViec_02_Kien
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
        public void ThemCongViecVaoThe_Dacta_02_Kien ( )
        {
            DangNhapVaoTrello_02_kien();

            var tenBang_02_kien = "Kiem Thu Website Trello"; // Thay thế bằng tên của bảng bạn muốn chọn
            var Bang_02_kien = wait_02_kien.Until(ExpectedConditions.ElementIsVisible(By.XPath($"//div[@class='board-tile-details-name' and contains(@title,'{tenBang_02_kien}')]")));

            if (Bang_02_kien != null)
            {
                Bang_02_kien.Click();

                var theCanTaoChecklist_02_kien = wait_02_kien.Until(ExpectedConditions.ElementIsVisible(By.XPath("//div[contains(@class, 'amUfYqLTZOvGsn')]//a[contains(text(), 'Đặc tả')]")));
                theCanTaoChecklist_02_kien.Click();

                var nutChecklist_02_kien = wait_02_kien.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("button.hEwr0TTqyuHAdq")));
                nutChecklist_02_kien.Click();

                var TextBox_02_kien = wait_02_kien.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("input#id-checklist")));
                TextBox_02_kien.Clear();

                TextBox_02_kien.SendKeys("Checklist mới");

                var nutThem_02_kien = wait_02_kien.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("button.HwRbvTPVxzo9OE")));
                nutThem_02_kien.Click();

                var textareaCongViecDauTien_02_kien = wait_02_kien.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("textarea.edit.field.checklist-new-item-text.js-new-checklist-item-input")));
                textareaCongViecDauTien_02_kien.SendKeys("Công việc đầu tiên");

                var nutThemDauTien_02_kien = wait_02_kien.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("input.nch-button.nch-button--primary.confirm.mod-submit-edit.js-add-checklist-item")));
                nutThemDauTien_02_kien.Click();

                var textareaCongViecThuHai_02_kien = wait_02_kien.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("textarea.edit.field.checklist-new-item-text.js-new-checklist-item-input")));
                textareaCongViecThuHai_02_kien.SendKeys("Công việc thứ hai");

                var nutThemThuHai_02_kien = wait_02_kien.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("input.nch-button.nch-button--primary.confirm.mod-submit-edit.js-add-checklist-item")));
                nutThemThuHai_02_kien.Click();
            }
            else
            {
                Assert.Fail("Không thể truy cập vào bảng để tạo thẻ.");
            }
        }

        [Test]
        public void ThemCongViecVaoThe_testcase_02_Kien ( )
        {
            DangNhapVaoTrello_02_kien();

            var tenBang_02_kien = "Kiem Thu Website Trello"; // Thay thế bằng tên của bảng bạn muốn chọn
            var Bang_02_kien = wait_02_kien.Until(ExpectedConditions.ElementIsVisible(By.XPath($"//div[@class='board-tile-details-name' and contains(@title,'{tenBang_02_kien}')]")));

            if (Bang_02_kien != null)
            {
                Bang_02_kien.Click();

                var theCanTaoChecklist_02_kien = wait_02_kien.Until(ExpectedConditions.ElementIsVisible(By.XPath("//div[contains(@class, 'amUfYqLTZOvGsn')]//a[contains(text(), 'Test case')]")));
                theCanTaoChecklist_02_kien.Click();

                var nutChecklist_02_kien = wait_02_kien.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("button.hEwr0TTqyuHAdq")));
                nutChecklist_02_kien.Click();

                var TextBox_02_kien = wait_02_kien.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("input#id-checklist")));
                TextBox_02_kien.Clear();

                TextBox_02_kien.SendKeys("Checklist mới");

                var nutThem_02_kien = wait_02_kien.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("button.HwRbvTPVxzo9OE")));
                nutThem_02_kien.Click();

                var textareaCongViecDauTien_02_kien = wait_02_kien.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("textarea.edit.field.checklist-new-item-text.js-new-checklist-item-input")));
                textareaCongViecDauTien_02_kien.SendKeys("Công việc đầu tiên");

                var nutThemDauTien_02_kien = wait_02_kien.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("input.nch-button.nch-button--primary.confirm.mod-submit-edit.js-add-checklist-item")));
                nutThemDauTien_02_kien.Click();

                var textareaCongViecThuHai_02_kien = wait_02_kien.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("textarea.edit.field.checklist-new-item-text.js-new-checklist-item-input")));
                textareaCongViecThuHai_02_kien.SendKeys("Công việc thứ hai");

                var nutThemThuHai_02_kien = wait_02_kien.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("input.nch-button.nch-button--primary.confirm.mod-submit-edit.js-add-checklist-item")));
                nutThemThuHai_02_kien.Click();
            }
            else
            {
                Assert.Fail("Không thể truy cập vào bảng để tạo thẻ.");
            }
        }

        [Test]
        public void ThemCongViecVaoThe_Vietbaocao_02_Kien ( )
        {
            DangNhapVaoTrello_02_kien();

            var tenBang_02_kien = "Kiem Thu Website Trello"; // Thay thế bằng tên của bảng bạn muốn chọn
            var Bang_02_kien = wait_02_kien.Until(ExpectedConditions.ElementIsVisible(By.XPath($"//div[@class='board-tile-details-name' and contains(@title,'{tenBang_02_kien}')]")));

            if (Bang_02_kien != null)
            {
                Bang_02_kien.Click();

                var theCanTaoChecklist_02_kien = wait_02_kien.Until(ExpectedConditions.ElementIsVisible(By.XPath("//div[contains(@class, 'amUfYqLTZOvGsn')]//a[contains(text(), 'Viết báo cáo')]")));
                theCanTaoChecklist_02_kien.Click();

                var nutChecklist_02_kien = wait_02_kien.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("button.hEwr0TTqyuHAdq")));
                nutChecklist_02_kien.Click();

                var TextBox_02_kien = wait_02_kien.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("input#id-checklist")));
                TextBox_02_kien.Clear();

                TextBox_02_kien.SendKeys("Checklist mới");

                var nutThem_02_kien = wait_02_kien.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("button.HwRbvTPVxzo9OE")));
                nutThem_02_kien.Click();

                var textareaCongViecDauTien_02_kien = wait_02_kien.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("textarea.edit.field.checklist-new-item-text.js-new-checklist-item-input")));
                textareaCongViecDauTien_02_kien.SendKeys("Công việc đầu tiên");

                var nutThemDauTien_02_kien = wait_02_kien.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("input.nch-button.nch-button--primary.confirm.mod-submit-edit.js-add-checklist-item")));
                nutThemDauTien_02_kien.Click();

                var textareaCongViecThuHai_02_kien = wait_02_kien.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("textarea.edit.field.checklist-new-item-text.js-new-checklist-item-input")));
                textareaCongViecThuHai_02_kien.SendKeys("Công việc thứ hai");

                var nutThemThuHai_02_kien = wait_02_kien.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("input.nch-button.nch-button--primary.confirm.mod-submit-edit.js-add-checklist-item")));
                nutThemThuHai_02_kien.Click();
            }
            else
            {
                Assert.Fail("Không thể truy cập vào bảng để tạo thẻ.");
            }
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

            var nutGuiDangNhap_02_kien = wait_02_kien.Until(ExpectedConditions.ElementToBeClickable(By.Id("login-submit")));
            nutGuiDangNhap_02_kien.Click();
        }

        [TearDown]
        public void Teardown_02_kien ( )
        {
            System.Threading.Thread.Sleep(5000);
            driver_02_kien.Quit();
        }
    }
}
