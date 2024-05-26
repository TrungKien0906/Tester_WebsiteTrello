using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;


namespace TestTrello_02_NguyenTrungKien.UnitTest_Trello_02_Kien
{
    [TestFixture]
    public class KiemTraTaoBang_02_Kien
    {
        private IWebDriver driver_02_kien;
        private WebDriverWait wait_02_kien;

        [SetUp]
        public void SetupKiemTra_02_Kien ( )
        {
            driver_02_kien = new ChromeDriver();
            driver_02_kien.Manage().Window.Maximize();
            driver_02_kien.Navigate().GoToUrl("https://trello.com/");

            wait_02_kien = new WebDriverWait(driver_02_kien, TimeSpan.FromSeconds(30));
        }

        [Test, Order(1)]
        public void KiemTraTaoBang_VoiTieuDeHopLe_ThanhCong_02_Kien ( )
        {
            DangNhapVaoTrello_02_Kien();
            bool isBoardCreated = TaoBang_02_Kien("Kiểm Thử Website Trello");
            Assert.IsTrue(isBoardCreated, "Tạo bảng mới thành công.");
        }


        [Test, Order(2)]
        public void KiemTraTaoTheSauKhiTaoBang_02_Kien ( )
        {
            DangNhapVaoTrello_02_Kien();
            TaoTheSauKhiTaoBang_02_Kien("Kiểm Thử Website Trello", "Thiết kế test case");

            Assert.IsTrue(driver_02_kien.Url.Contains("https://trello.com/b/"), "Chuyển đến trang thẻ mới thành công.");
        }


        [Test, Order(3)]
        public void KiemTraThemCongViecVaoTheDaTao_02_Kien ( )
        {

            DangNhapVaoTrello_02_Kien();

            
            var boardTitle_02_Kien = "Kiểm Thử Website Trello";
            var cardTitle_02_Kien = "Thiết kế test case";
            var congViecMoi_02_Kien = "Công việc mới";
            var checklistTitle_02_Kien = "Checklist mới";
            ThemCongViecVaoTheDaTao_02_Kien(boardTitle_02_Kien, cardTitle_02_Kien, checklistTitle_02_Kien, congViecMoi_02_Kien);

            
            var congViecTrongThe_02_Kien = wait_02_kien.Until(ExpectedConditions.ElementIsVisible(By.XPath($"//a[contains(text(), '{cardTitle_02_Kien}')]//following::textarea[contains(@class, 'js-new-checklist-item-input')]")));
            Assert.IsNotNull(congViecTrongThe_02_Kien, "Công việc đã được thêm vào thẻ thành công.");
        }



        [Test, Order(4)]
        public void KiemTraTaoBangThuHai_VoiTenGiongBangDau_02_Kien ( )
        {
            DangNhapVaoTrello_02_Kien();
            bool isFirstBoardCreated_02_Kien = TaoBang_02_Kien("Kiểm Thử Website Trello");

           
            bool isSecondBoardCreated_02_Kien = TaoBang_02_Kien("Kiểm Thử Website Trello");
            Assert.IsFalse(isSecondBoardCreated_02_Kien, "Không thể tạo bảng thứ hai với tên giống bảng đầu.");
        }

        [TearDown]
        public void DonDepKiemTra_02_Kien ( )
        {
            driver_02_kien.Quit();
        }

        private void DangNhapVaoTrello_02_Kien ( )
        {
            var nutDangNhap_02_Kien = wait_02_kien.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("a[data-uuid='MJFtCCgVhXrVl7v9HA7EH_login']")));
            nutDangNhap_02_Kien.Click();

            var NhapEmail_02_Kien = wait_02_kien.Until(ExpectedConditions.ElementToBeClickable(By.Id("username")));
            NhapEmail_02_Kien.SendKeys("2051010152kien@ou.edu.vn");

            var nutTiepTuc_02_Kien = wait_02_kien.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("span.css-178ag6o")));
            nutTiepTuc_02_Kien.Click();

            var NhapMatKhau_02_Kien = wait_02_kien.Until(ExpectedConditions.ElementToBeClickable(By.Id("password")));
            NhapMatKhau_02_Kien.SendKeys("ntk205600");

            var nutDangNhapT_02_Kien = wait_02_kien.Until(ExpectedConditions.ElementToBeClickable(By.Id("login-submit")));
            nutDangNhapT_02_Kien.Click();
        }

        private bool TaoBang_02_Kien ( string tieuDe )
        {
            try
            {
                var nutTaoBangMoi_02_Kien = wait_02_kien.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("div.board-tile.mod-add")));
                nutTaoBangMoi_02_Kien.Click();

                var NhapTieuDe_02_Kien = wait_02_kien.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("input[data-testid='create-board-title-input']")));
                NhapTieuDe_02_Kien.Clear();
                NhapTieuDe_02_Kien.SendKeys(tieuDe);

                var nutTao_02_Kien = wait_02_kien.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("button[data-testid='create-board-submit-button']")));
                nutTao_02_Kien.Click();

               
                wait_02_kien.Until(ExpectedConditions.UrlContains("https://trello.com/c/"));

                return false;
            }
            catch (WebDriverTimeoutException)
            {
                return true; 
            }
            catch (NoSuchElementException)
            {
                return true; 
            }
        }



        private void TaoTheSauKhiTaoBang_02_Kien ( string tieuDeBang, string tieuDeThe )
        {
            // Chờ đợi bảng được tải
            var bang_02_Kien = wait_02_kien.Until(ExpectedConditions.ElementIsVisible(By.XPath($"//div[@class='board-tile-details is-badged']//div[@class='board-tile-details-name'][normalize-space()='{tieuDeBang}']")));
            bang_02_Kien.Click();

            // Chờ đợi thẻ được thêm
            var nutThemThe_02_Kien = wait_02_kien.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("button[data-testid='list-add-card-button']")));
            nutThemThe_02_Kien.Click();

            // Nhập tiêu đề thẻ
            var oNhapTieuDeThe_02_Kien = wait_02_kien.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("textarea[data-testid='list-card-composer-textarea']")));
            oNhapTieuDeThe_02_Kien.SendKeys(tieuDeThe);

            // Nhấp vào nút "Thêm thẻ"
            var nutThemTheXacNhan_02_Kien = wait_02_kien.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("button[data-testid='list-card-composer-add-card-button']")));
            nutThemTheXacNhan_02_Kien.Click();

            // Chờ đợi thẻ được tạo
            Thread.Sleep(2000); // Thêm một độ trễ để đảm bảo thẻ được tạo trước khi tiếp tục
        }

        private void ThemCongViecVaoTheDaTao_02_Kien ( string tieuDeBang, string tieuDeThe, string tieuDeChecklist, string congViec )
        {
            // Nhấp vào bảng
            var bang_02_Kien = wait_02_kien.Until(ExpectedConditions.ElementToBeClickable(By.XPath($"//div[@class='board-tile-details is-badged']//div[@class='board-tile-details-name'][normalize-space()='{tieuDeBang}']")));
            bang_02_Kien.Click();

            // Tìm và nhấp vào thẻ
            var the_02_Kien = wait_02_kien.Until(ExpectedConditions.ElementToBeClickable(By.XPath($"//div[contains(@class, 'amUfYqLTZOvGsn')]//a[contains(text(), '{tieuDeThe}')]")));
            the_02_Kien.Click();

            // Chờ đợi và nhấp vào nút "Checklist"
            var nutChecklist_02_Kien = wait_02_kien.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("div.js-add-checklist-menu button")));
            nutChecklist_02_Kien.Click();

            // Chờ đợi và nhập tiêu đề của checklist
            var NhapChecklist_02_Kien = wait_02_kien.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("input#id-checklist")));
            NhapChecklist_02_Kien.Clear();
            NhapChecklist_02_Kien.SendKeys(tieuDeChecklist);

            // Chờ đợi và nhấp vào nút "Thêm" của checklist
            var nutThem_02_Kien = wait_02_kien.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("button.HwRbvTPVxzo9OE")));
            nutThem_02_Kien.Click();

            // Chờ đợi và nhập công việc mới
            var NhapCongViecMoi_02_Kien = wait_02_kien.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("textarea.edit.field.checklist-new-item-text.js-new-checklist-item-input")));
            NhapCongViecMoi_02_Kien.SendKeys(congViec);

            // Nhấp vào nút "Thêm"
            var nutThemMoi_02_Kien = wait_02_kien.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("input.nch-button.nch-button--primary.confirm.mod-submit-edit.js-add-checklist-item")));
            nutThemMoi_02_Kien.Click();
        }
    }
}
