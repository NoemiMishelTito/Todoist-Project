using OpenQA.Selenium;
using Todoist_Project.src.code.control;
using Todoist_Project.src.code.page;

namespace Todoist_Project.src.code.test
{
    [TestClass]
    public class CreateProject : TestBase
    {
        loginpage gologin = new loginpage();
        ManageProjectPage createProject = new ManageProjectPage();

        [TestMethod]
        public void CreateNewProject()
        {
            gologin.LoginRedirection();
            // Login Url verification
            Assert.IsTrue(session.Session.Instance().GetCurrentUrl().Equals("https://todoist.com/auth/login"), "The url is different from https://todoist.com/auth/login");
            gologin.LoginSession("mt_auto@test.com", "mt_Qatest123");
            // Home page Url verification
            Assert.IsTrue(session.Session.Instance().GetCurrentUrl().Equals("https://todoist.com/app/today"), "The url is different from https://todoist.com/app/today"); 
            createProject.OpenProjectField();
            // Projects page url verification
            Assert.IsTrue(session.Session.Instance().GetCurrentUrl().Equals("https://todoist.com/app/projects/active"), "The url is different from https://todoist.com/app/projects/active");
            createProject.ClickNewProject();
            createProject.CreateNewProject("Project-Mojix");
            //Verify project
            Assert.IsTrue(createProject.ProjectNameIsDisplayed("Project-Mojix"), "ERROR!The project was not created");
            Thread.Sleep(3000);
        }
    }
}
