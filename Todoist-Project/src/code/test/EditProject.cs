using OpenQA.Selenium;
using Todoist_Project.src.code.control;
using Todoist_Project.src.code.page;

namespace Todoist_Project.src.code.test
{
    [TestClass]
    public class EditProject : TestBase
    {
        loginpage gologin = new loginpage();
        EditProjectPage editproject = new EditProjectPage();
        ManageProjectPage createProject = new ManageProjectPage();

        [TestMethod]
        public void EditExistingProject()
        {
            gologin.LoginRedirection();
            // Login Url verification
            Assert.IsTrue(session.Session.Instance().GetCurrentUrl().Equals("https://todoist.com/auth/login"), "The url is different from https://todoist.com/auth/login");
            gologin.LoginSession("mt_auto@test.com", "mt_Qatest123");
            // Home page Url verification
            Assert.IsTrue(session.Session.Instance().GetCurrentUrl().Equals("https://todoist.com/app/today"), "The url is different from https://todoist.com/app/today");
            editproject.OpenExistingProjectField();
            editproject.EditExistingProject("Project-Mojix-Edit");
            //Verify project
            Assert.IsTrue(createProject.ProjectNameIsDisplayed("Project-Mojix-Edit"), "ERROR!The project was not edited correctly");

        }
    }
}
