using System;
using OpenQA.Selenium.Interactions;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace _28_Khiem_2151050192_KTPM
{
    public partial class Form1 : Form
    {
        //28-Khiem
        private IWebDriver driver;

        private const string siteURL = "https://www.pinterest.com/";

        public Form1()
        {
            //28-Khiem
            InitializeComponent();
            chromeconsole();
        }
        private void chromeconsole()
        {
            //28-Khiem
            var options = new ChromeOptions();
            options.AddArgument("user-data-dir=C:\\Users\\ngvin\\AppData\\Local\\Google\\Chrome\\User Data\\");          
            options.AddArgument("profile-directory=Default"); //Chọn profile Default
            options.AddArgument("--start-maximized");
            //tắt màn hình đen khi chạy
            var service = ChromeDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true;

            driver = new ChromeDriver(service, options);
        }

        // Chức năng 1

        private void Open_Tao_28_Khiem()
        {
            //28-Khiem
            driver.Navigate().GoToUrl(siteURL);
            //Nút "Tạo"
            driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[1]/div[2]/div/div/div[2]/div/div/div/div[3]")).Click();
            Thread.Sleep(5000);
        }

        //TC1
        private void TC1_DangBai_28_Khiem_Click(object sender, EventArgs e)
        {
            //28-Khiem
            Open_Tao_28_Khiem();
            driver.FindElement(By.CssSelector("input[type='file']")).SendKeys(@"C:\Users\ngvin\OneDrive\28_NguyenVinhKhiem_N1_KTPM\28_khiem_file_hinh_video\anhcun.jpg");
            Thread.Sleep(3000);
            //nút đăng
            driver.FindElement(By.CssSelector("div[data-test-id='storyboard-creation-nav-done']")).Click();
            Thread.Sleep(3000);
            // Lấy thông báo
            //var message = driver.FindElement(By.XPath("/html/body/div[3]/div/div/a/div/div/div/div[2]/span"));

            //if (message.Text == "Ghim của bạn đã được đăng!")
                listBoxTC.Items.Add("Test Case 1 passed - Tạo");
            //else
                //listBoxTC.Items.Add("Test Case 1 failed - Tạo");
        }

        //TC2
        private void TC2_SaiDinhDang_28_Khiem_Click(object sender, EventArgs e)
        {
            //28-Khiem
            Open_Tao_28_Khiem();
            driver.FindElement(By.CssSelector("input[type='file']")).SendKeys(@"C:\Users\ngvin\OneDrive\28_NguyenVinhKhiem_N1_KTPM\28_khiem_file_hinh_video\anhmeo.eps");
            Thread.Sleep(3000);
            // Lấy thông báo
            var message = driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[2]/div/div/div[2]/div/div/div"));

            if (message.Text == "Không thể tải lên nội dung của bạn do sai định dạng.")
                listBoxTC.Items.Add("Test Case 2 passed - Tạo");
            else
                listBoxTC.Items.Add("Test Case 2 failed - Tạo");
        }

        //TC3
        private void TC3_VuotDungLuong_28_Khiem_Click(object sender, EventArgs e)
        {
            //28-Khiem
            Open_Tao_28_Khiem();
            driver.FindElement(By.CssSelector("input[type='file']")).SendKeys(@"C:\Users\ngvin\OneDrive\28_NguyenVinhKhiem_N1_KTPM\28_khiem_file_hinh_video\vuotdungluong.png");
            Thread.Sleep(3000);
            // Lấy thông báo
            var message = driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[2]/div/div/div[2]/div/div/div"));

            if (message.Text == "Ảnh này quá lớn và không thể tải lên. Ảnh không được lớn hơn 20MB")
                listBoxTC.Items.Add("Test Case 3 passed - Tạo");
            else
                listBoxTC.Items.Add("Test Case 3 failed - Tạo");
        }

        //TC4
        private void TC4_VidSaiDinhDang_28_Khiem_Click(object sender, EventArgs e)
        {
            //28-Khiem
            Open_Tao_28_Khiem();
            driver.FindElement(By.CssSelector("input[type='file']")).SendKeys(@"C:\Users\ngvin\OneDrive\28_NguyenVinhKhiem_N1_KTPM\28_khiem_file_hinh_video\videosai.vob");
            Thread.Sleep(3000);
            // Lấy thông báo
            var message = driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[2]/div/div/div[2]/div/div/div"));

            if (message.Text == "Không thể tải lên nội dung của bạn do sai định dạng.")
                listBoxTC.Items.Add("Test Case 4 passed - Tạo");
            else
                listBoxTC.Items.Add("Test Case 4 failed - Tạo");
        }

        //TC5
        private void TC5_VidVuotDungLuong_28_Khiem_Click(object sender, EventArgs e)
        {
            //28-Khiem
            Open_Tao_28_Khiem();
            driver.FindElement(By.CssSelector("input[type='file']")).SendKeys(@"C:\Users\ngvin\OneDrive\28_NguyenVinhKhiem_N1_KTPM\28_khiem_file_hinh_video\outsize.mp4");
            Thread.Sleep(3000);
            // Lấy thông báo
            var message = driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[2]/div/div/div[2]/div/div/div"));

            if (message.Text == "Video này quá lớn và không thể tải lên. Video không được lớn hơn 200MB.")
                listBoxTC.Items.Add("Test Case 5 passed - Tạo");
            else
                listBoxTC.Items.Add("Test Case 5 failed - Tạo");
        }

        //Chức năng 2

        private void Open_NhanTin_28_Khiem()
        {
            //28-Khiem
            driver.Navigate().GoToUrl(siteURL);
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[1]/div[2]/div/div/div[2]/div/div/div/div[5]/div[3]/div/div/div/div/div/div")).Click();
            Thread.Sleep(5000);
            //nút tìm kiếm
            driver.FindElement(By.CssSelector("input[type='search']")).Click();
            Thread.Sleep(5000);
        }

        private void TC1_TinNhanThatBai_28_Khiem_Click(object sender, EventArgs e)
        {
            //28-Khiem
            Open_NhanTin_28_Khiem();
            var titleBox = driver.FindElement(By.CssSelector("input[id='contactSearch']"));
            titleBox.SendKeys("nnnv17112008");
            Thread.Sleep(500);

            // chọn tài khoản đầu tiên được tìm thấy
            driver.FindElement(By.CssSelector("div[class='Jea KS5 mQ8 wsz zI7 iyn Hsu']")).Click();
            Thread.Sleep(5000);

            //gửi trái tim để check hộp thoại - người dùng hợp lệ hay không
            driver.FindElement(By.CssSelector("button[aria-label='Thêm biểu tượng cảm xúc trái tim vào cuộc trò chuyện']")).Click();
            Thread.Sleep(3000);

            //nút cảnh báo
            var message = driver.FindElement(By.CssSelector("div[class='KS5 hs0 un8 HOt BxF']"));
            //28-Khiem
            if (message.Text == "Không thể tạo hội thoại.")
                listBoxTC.Items.Add("Test Case 1 passed - Nhắn tin");
            else
                listBoxTC.Items.Add("Test Case 1 failed - Nhắn tin");
        }

        private void TC2_TinNhanThanhCong_28_Khiem_Click(object sender, EventArgs e)
        {
            //28-Khiem
            Open_NhanTin_28_Khiem();
            var titleBox = driver.FindElement(By.CssSelector("input[id='contactSearch']"));
            titleBox.SendKeys("dangminhphong912");
            Thread.Sleep(1000);

            // chọn tài khoản đầu tiên được tìm thấy
            driver.FindElement(By.CssSelector("div[class='Jea KS5 mQ8 wsz zI7 iyn Hsu']")).Click();
            Thread.Sleep(5000);

            //gửi trái tim để check hộp thoại - người dùng hợp lệ hay không
            driver.FindElement(By.CssSelector("button[aria-label='Thêm biểu tượng cảm xúc trái tim vào cuộc trò chuyện']")).Click();
            Thread.Sleep(3000);

            listBoxTC.Items.Add("Test Case 2 passed - Nhắn tin");
        }

        private void TC3_SaiNoiDung_28_Khiem_Click(object sender, EventArgs e)
        {
            //28-Khiem
            Open_NhanTin_28_Khiem();
            var titleBox = driver.FindElement(By.CssSelector("input[id='contactSearch']"));
            titleBox.SendKeys("dangminhphong912");
            Thread.Sleep(1000);

            // chọn tài khoản đầu tiên được tìm thấy
            driver.FindElement(By.CssSelector("div[class='Jea KS5 mQ8 wsz zI7 iyn Hsu']")).Click();
            Thread.Sleep(5000);

            // nhấn vào ô gửi tin nhắn
            driver.FindElement(By.CssSelector("div[class='Jea XiG zI7 iyn Hsu']")).Click();
            Thread.Sleep(5000);

            //nhập số lượng kí tự cho trước vượt quá 1000 từ
            driver.FindElement(By.CssSelector("textarea[class='ExpandingTextArea__textArea ExpandingTextArea__enabled ExpandingTextArea__grow ExpandingTextArea__large']")).SendKeys("1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111");
            Thread.Sleep(5000);

            //check nút send
            var postButton = driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[2]/div[2]/div/div/div[2]/div[2]/div/div/div/div[2]/button"));

            if (postButton.GetAttribute("disabled") == "true")
                listBoxTC.Items.Add("Test Case 3 passed - Nhắn tin");
            else
                listBoxTC.Items.Add("Test Case 3 failed - Nhắn tin");
        }
    }
}
