    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Interactions;
    using OpenQA.Selenium.Support.UI;
    using SeleniumExtras.WaitHelpers;


    namespace Webdriver_Trello_02_NguyenTrungKien.Testcase2_ChucNangChinh_02_NguyenTrungKien
    {
        [TestFixture]
        public class Testcase2_4_XuLyCongViec_02_Kien
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

            [Test, Order(1)]
            public void TestChonHetMuc_DacTa_02_Kien ( )
            {
                DangNhapVaoTrello_02_kien();

                var tenBang_02_kien = "Kiem Thu Website Trello";
                var Bang_02_kien = wait_02_kien.Until(ExpectedConditions.ElementIsVisible(By.XPath($"//div[@class='board-tile-details-name' and contains(@title,'{tenBang_02_kien}')]")));
                Bang_02_kien.Click();

                var theCanChinhSua_02_kien = wait_02_kien.Until(ExpectedConditions.ElementIsVisible(By.XPath("//div[contains(@class, 'amUfYqLTZOvGsn')]//a[contains(text(), 'Đặc tả')]")));
                theCanChinhSua_02_kien.Click();

                ChonTatCaCacMucChecklist_02_kien();

                Thread.Sleep(2000);
            }

            [Test, Order(2)]
            public void TestDiChuyenTHe_DacTa_02_Kien ( )
            {
                DangNhapVaoTrello_02_kien();

                var tenBang_02_kien = "Kiem Thu Website Trello";
                var Bang_02_kien = wait_02_kien.Until(ExpectedConditions.ElementIsVisible(By.XPath($"//div[@class='board-tile-details-name' and contains(@title,'{tenBang_02_kien}')]")));
                Bang_02_kien.Click();

                var element_02_kien = wait_02_kien.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("div.amUfYqLTZOvGsn")));
                Actions action_02_kien = new Actions(driver_02_kien);
                action_02_kien.ContextClick(element_02_kien).Perform();

                var nutChuyen_02_kien = driver_02_kien.FindElement(By.CssSelector("button[data-testid='quick-card-editor-move']"));
                nutChuyen_02_kien.Click();

                var menuDropdown_02_kien = driver_02_kien.FindElement(By.CssSelector("select.js-select-list"));
                SelectElement select_02_kien = new SelectElement(menuDropdown_02_kien);
                select_02_kien.SelectByText("Đã xong");

                var nutChuyen2_02_kien = driver_02_kien.FindElement(By.CssSelector("input[data-testid='move-card-popover-move-button']"));
                nutChuyen2_02_kien.Click();

                Thread.Sleep(2000);
            }

            [Test, Order(3)]
            public void TestDangLam_Testcase_02_Kien ( )
            {
                DangNhapVaoTrello_02_kien();

                var tenBang_02_kien = "Kiem Thu Website Trello";
                var Bang_02_kien = wait_02_kien.Until(ExpectedConditions.ElementIsVisible(By.XPath($"//div[@class='board-tile-details-name' and contains(@title,'{tenBang_02_kien}')]")));
                Bang_02_kien.Click();

                var theCanChinhSua_02_kien = wait_02_kien.Until(ExpectedConditions.ElementIsVisible(By.XPath("//div[contains(@class, 'amUfYqLTZOvGsn')]//a[contains(text(), 'Test case')]")));
                theCanChinhSua_02_kien.Click();
                ChonMotSoMucChecklist_02_kien();

            }

            [Test, Order(4)]
            public void TestDiChuyenThe_Testcase_02_Kien ( )
            {
                DangNhapVaoTrello_02_kien();

                var tenBang_02_kien = "Kiem Thu Website Trello";
                var Bang_02_kien = wait_02_kien.Until(ExpectedConditions.ElementIsVisible(By.XPath($"//div[@class='board-tile-details-name' and contains(@title,'{tenBang_02_kien}')]")));
                Bang_02_kien.Click();

                var testCaseCard_02_kien = wait_02_kien.Until(ExpectedConditions.ElementIsVisible(By.XPath("//div[contains(@class, 'amUfYqLTZOvGsn')]//a[contains(text(), 'Test case')]")));
                Actions action_02_kien = new Actions(driver_02_kien);
                action_02_kien.ContextClick(testCaseCard_02_kien).Perform();

                var nutChuyen_02_kien = driver_02_kien.FindElement(By.CssSelector("button[data-testid='quick-card-editor-move']"));
                nutChuyen_02_kien.Click();

                var menuDropdown_02_kien = driver_02_kien.FindElement(By.CssSelector("select.js-select-list"));
                SelectElement select_02_kien = new SelectElement(menuDropdown_02_kien);
                select_02_kien.SelectByText("Đang làm");

                var nutChuyen2_02_kien = driver_02_kien.FindElement(By.CssSelector("input[data-testid='move-card-popover-move-button']"));
                nutChuyen2_02_kien.Click();

                Thread.Sleep(2000);
            }

            [Test, Order(5)]
            public void TestDangLam_VietBaoCao_02_Kien ( )
            {
                DangNhapVaoTrello_02_kien();

                var tenBang_02_kien = "Kiem Thu Website Trello";
                var Bang_02_kien = wait_02_kien.Until(ExpectedConditions.ElementIsVisible(By.XPath($"//div[@class='board-tile-details-name' and contains(@title,'{tenBang_02_kien}')]")));
                Bang_02_kien.Click();

                var theCanChinhSua_02_kien = wait_02_kien.Until(ExpectedConditions.ElementIsVisible(By.XPath("//div[contains(@class, 'amUfYqLTZOvGsn')]//a[contains(text(), 'Viết báo cáo')]")));
                theCanChinhSua_02_kien.Click();
                ChonMotSoMucChecklist_02_kien();

            }

            [Test, Order(6)]
            public void TestDiCHuyenTHe_VietBaoCao_02_Kien ( )
            {
                DangNhapVaoTrello_02_kien();

                var tenBang_02_kien = "Kiem Thu Website Trello";
                var Bang_02_kien = wait_02_kien.Until(ExpectedConditions.ElementIsVisible(By.XPath($"//div[@class='board-tile-details-name' and contains(@title,'{tenBang_02_kien}')]")));
                Bang_02_kien.Click();

                var vietBaoCaoCard_02_kien = wait_02_kien.Until(ExpectedConditions.ElementIsVisible(By.XPath("//div[contains(@class, 'amUfYqLTZOvGsn')]//a[contains(text(), 'Viết báo cáo')]")));
                Actions action_02_kien = new Actions(driver_02_kien);
                action_02_kien.ContextClick(vietBaoCaoCard_02_kien).Perform();

                var nutChuyen_02_kien = driver_02_kien.FindElement(By.CssSelector("button[data-testid='quick-card-editor-move']"));
                nutChuyen_02_kien.Click();

                var menuDropdown_02_kien = driver_02_kien.FindElement(By.CssSelector("select.js-select-list"));
                SelectElement select_02_kien = new SelectElement(menuDropdown_02_kien);
                select_02_kien.SelectByText("Đang làm");

                var nutChuyen2_02_kien = driver_02_kien.FindElement(By.CssSelector("input[data-testid='move-card-popover-move-button']"));
                nutChuyen2_02_kien.Click();

                Thread.Sleep(2000);
            }

            private void ChonTatCaCacMucChecklist_02_kien ( )
            {
                var danhSachChecklist_02_kien = wait_02_kien.Until(ExpectedConditions.ElementIsVisible(By.ClassName("checklist")));
                var cacMucChecklist_02_kien = danhSachChecklist_02_kien.FindElements(By.CssSelector(".checklist-item-checkbox"));
                foreach (var muc in cacMucChecklist_02_kien)
                {
                    if (!muc.Selected)
                    {
                        muc.Click();
                    }
                }
            }

      
            private void ChonMotSoMucChecklist_02_kien ( )
            {
                var danhSachChecklist_02_kien = wait_02_kien.Until(ExpectedConditions.ElementIsVisible(By.ClassName("checklist")));
                var cacMucChecklist_02_kien = danhSachChecklist_02_kien.FindElements(By.CssSelector(".checklist-item-checkbox"));

               
                if (cacMucChecklist_02_kien.Count == 0)
                {
                    Console.WriteLine("Không có mục checklist nào để chọn.");
                    return;
                }

                Random random_02_kien = new Random();
                int soMucCanChon_02_kien = random_02_kien.Next(1, cacMucChecklist_02_kien.Count + 1); // Thêm 1 vào maxValue
                for (int i = 0; i < soMucCanChon_02_kien; i++)
                {
                    int chiSo_02_kien = random_02_kien.Next(cacMucChecklist_02_kien.Count);
                    if (!cacMucChecklist_02_kien[chiSo_02_kien].Selected)
                    {
                        cacMucChecklist_02_kien[chiSo_02_kien].Click();
                    }
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
                Thread.Sleep(5000);
                driver_02_kien.Quit();
            }
        }
    }
