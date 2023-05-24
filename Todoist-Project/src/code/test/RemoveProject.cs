using OpenQA.Selenium;
using Todoist_Project.src.code.control;
using Todoist_Project.src.code.page;

namespace Todoist_Project.src.code.test
{
    [TestClass]
    public class RemoveProject : TestBase
    {
        loginpage gologin = new loginpage();
        ManageProjectPage createProject = new ManageProjectPage();
        DeleteProjectPage deleteProject = new DeleteProjectPage();

        [TestMethod]
        public void RemoveExistingProject()
        {
            gologin.LoginRedirection();
            // Login Url verification
            Assert.IsTrue(session.Session.Instance().GetCurrentUrl().Equals("https://todoist.com/auth/login"), "The url is different from https://todoist.com/auth/login");
            gologin.LoginSession("mt_auto@test.com", "mt_Qatest123");
            // Home page Url verification
            Assert.IsTrue(session.Session.Instance().GetCurrentUrl().Equals("https://todoist.com/app/today"), "The url is different from https://todoist.com/app/today");
            deleteProject.OpenExistingProjectField();
            deleteProject.DeleteExistingProject();
            //Verify project
            Assert.IsFalse(createProject.ProjectNameIsDisplayed("Project-Mojix-Edit"), "ERROR!The project was not removed");
            Thread.Sleep(3000);
        }
    }
}
