using OpenQA.Selenium;
using Todoist_Project.src.code.control;

namespace Todoist_Project.src.code.page
{
    public class loginpage
    {
        public Button loginBtn = new Button(By.LinkText("Log in"));
        public TextBox emailTxtBox = new TextBox(By.Id("element-0"));
        public TextBox pwTxtBox = new TextBox(By.Id("element-3"));
        public Button startLogin = new Button(By.XPath("//button[@data-gtm-id='start-email-login']"));

        public void LoginRedirection()
        {
            loginBtn.Click();
        }
        public void LoginSession(String email, String pw)
        {
            emailTxtBox.SetText(email);
            pwTxtBox.SetText(pw);
            startLogin.Click();
            Thread.Sleep(20000);
        }
    }
}
