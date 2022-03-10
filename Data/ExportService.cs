using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

class ExportService
{
    IWebDriver driver;

    public string ExportBracket(Dictionary<int, RegionalMatchup> winners, string username, string password, string host)
    {
        if(string.IsNullOrEmpty(username)){
			return "Username cannot be blank!";
		}
		if(string.IsNullOrEmpty(password)){
			return "Password cannot be blank!";
		}
        if (!VerifyWinners(winners)){
            return "Bracket is not completely filled out!";
        }
        driver = new ChromeDriver(".\\Driver");
        try { 
            if (host == "ESPN")
            {
                return ExportToESPN(winners,username,password);
            } else if (host == "CBS")
            {
                return ExportToCBS(winners,username,password);
            } else if (host == "Yahoo")
            {
                return ExportToYahoo(winners,username,password);
            }
            else if(host == "NCAA")
            {
                return ExportToNCAA(winners,username,password);
            }
            return "Export host not recognized!";
        }
        catch (Exception ex) {
            Console.WriteLine(ex.Message);
            return "Export to " + host + " failed!";
        }
        finally
        {
            //CloseDriver();
        }
    }

    private bool VerifyWinners(Dictionary<int, RegionalMatchup> winners){
        foreach(var rmatchup in winners.Values){
            foreach(var matchup in rmatchup.RegionalMatchups.Values)
            {
                if(string.IsNullOrEmpty(matchup.Team1.Name) || string.IsNullOrEmpty(matchup.Team2.Name))
                {
                    return false;
                }
            }
        }
        return true;
    }
    
    private void CloseDriver()
    {
        driver.Close();
    }

    /**
     * ESPN Export
     */
    private string ExportToESPN(Dictionary<int, RegionalMatchup> winners, string username, string password)
    {
        driver.Url = "https://fantasy.espn.com/tournament-challenge-bracket/2022/en/";
        ESPNLogin(driver, username, password);
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        wait.Until(d => d.FindElement(By.XPath("//*[@id='main-container']/div/section[1]/div/div[3]/div[3]/div[1]/a")));
        IWebElement createEntryBtn = driver.FindElement(By.XPath("//*[@id='main-container']/div/section[1]/div/div[3]/div[3]/div[1]/a"));
        createEntryBtn.Click();
        CloseDriver();
        return "";
    }

    private void ESPNLogin(IWebDriver driver, string username, string password)
    {
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        wait.Until(d => d.FindElement(By.XPath("//*[@id='global-header']/div[2]/ul/li[2]/a")));
        IWebElement login = driver.FindElement(By.XPath("//*[@id='global-header']/div[2]/ul/li[2]/a"));
        IWebElement loginFrame = driver.FindElements(By.TagName("iframe"))[5];
        login.Click();

        driver.SwitchTo().Frame(loginFrame);
        IWebElement usernameInput = driver.FindElement(By.XPath("//*[@id='did-ui-view']/div/section/section/form/section/div[1]/div/label/span[2]/input"));
        usernameInput.SendKeys(username);
        IWebElement passwordInput = driver.FindElement(By.XPath("//*[@id='did-ui-view']/div/section/section/form/section/div[2]/div/label/span[2]/input"));
        passwordInput.SendKeys(password);
        IWebElement loginBtn = driver.FindElement(By.XPath("//*[@id='did-ui-view']/div/section/section/form/section/div[3]/button"));
        loginBtn.Click();
    }

    /**
     * CBS Export
     */
    private string ExportToCBS(Dictionary<int, RegionalMatchup> winners, string username, string password)
    {
        driver.Url = "https://www.cbssports.com/college-basketball/bracketology/";
        CBSLogin(driver, username, password);
        return "";
    }
    
    private void CBSLogin(IWebDriver driver, string username, string password)
    {
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        wait.Until(d => d.FindElement(By.XPath("//*[@id='cbs-site-nav']/div/div[2]/ul/li[5]/a")));
        IWebElement login = driver.FindElement(By.XPath("//*[@id='cbs-site-nav']/div/div[2]/ul/li[5]/a"));
        login.Click();

        wait.Until(d => d.FindElement(By.XPath("//*[@id='app_login_username']")));
        IWebElement usernameInput = driver.FindElement(By.XPath("//*[@id='app_login_username']"));
        usernameInput.SendKeys(username);
        IWebElement passwordInput = driver.FindElement(By.XPath("//*[@id='app_login_password']"));
        passwordInput.SendKeys(password);
        IWebElement loginBtn = driver.FindElement(By.XPath("//*[@id='app_login']/div[3]/button"));
        loginBtn.Click();
    }
    
    /**
     * Yahoo Export
     */
    private string ExportToYahoo(Dictionary<int, RegionalMatchup> winners, string username, string password)
    {
        driver.Url = "https://tournament.fantasysports.yahoo.com/t1";
        YahooLogin(driver,username,password);
        IWebElement createBracket = driver.FindElement(By.XPath("//*[@id='main-1-Home-Proxy']/div/div[3]/div/div[2]/div/div[2]/a"));
        createBracket.Click();
        
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        wait.Until(d => d.FindElement(By.XPath("//*[@id='groupEmails']")));
        IWebElement groupEmailCheckbox = driver.FindElement(By.XPath("//*[@id='groupEmails']"));
        groupEmailCheckbox.Click();
        IWebElement notificationEmailCheckbox = driver.FindElement(By.XPath("//*[@id='notificationEmails']"));
        notificationEmailCheckbox.Click();
        IWebElement showEmailCheckbox = driver.FindElement(By.XPath("//*[@id='showEmail']"));
        showEmailCheckbox.Click();
        IWebElement joinContestCheckbox = driver.FindElement(By.XPath("//*[@id='joinContest']"));
        joinContestCheckbox.Click();

        IWebElement saveAndContinue = driver.FindElement(By.XPath("//*[@id='main-0-CreateBracket-Proxy']/div/div/div[4]/div[7]/button"));
        saveAndContinue.Click();
        return "";
    }
    
    private void YahooLogin(IWebDriver driver, string username, string password)
    {
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        wait.Until(d => d.FindElement(By.XPath("//*[@id='header-0-TourneyHeader-Proxy']/div/div/div[1]/div/div[2]/div/a[1]")));
        IWebElement login = driver.FindElement(By.XPath("//*[@id='header-0-TourneyHeader-Proxy']/div/div/div[1]/div/div[2]/div/a[1]"));
        login.Click();

        wait.Until(d => d.FindElement(By.XPath("//*[@id='login-username']")));
        IWebElement usernameInput = driver.FindElement(By.XPath("//*[@id='login-username']"));
        usernameInput.SendKeys(username);
        IWebElement usernameNext = driver.FindElement(By.XPath("//*[@id='login-signin']"));
        usernameNext.Click();
        
        wait.Until(d => d.FindElement(By.XPath("//*[@id='login-passwd']")));
        IWebElement passwordInput = driver.FindElement(By.XPath("//*[@id='login-passwd']"));
        passwordInput.SendKeys(password);
        IWebElement loginBtn = driver.FindElement(By.XPath("//*[@id='login-signin']"));
        loginBtn.Click();
    }
    
    /**
     * NCAA Export
     */
    private string ExportToNCAA(Dictionary<int, RegionalMatchup> winners, string username, string password)
    {
        driver.Url = "https://bracketchallenge.ncaa.com/";
        NCAALogin(driver,username,password);
        return "";
    }

    private void NCAALogin(IWebDriver driver, string username, string password)
    {
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

        wait.Until(d => d.FindElement(By.XPath("//*[@id='authenticate']/div[2]/button[2]")));
        IWebElement login = driver.FindElement(By.XPath("//*[@id='authenticate']/div[2]/button[2]"));
        login.Click();

        driver.SwitchTo().DefaultContent();

        wait.Until(d => d.FindElement(By.XPath("/html/body/div[5]/div/div[1]/div/form/div[1]/input")));        
        IWebElement usernameInput = driver.FindElement(By.XPath("/html/body/div[5]/div/div[1]/div/form/div[1]/input"));
        usernameInput.SendKeys(username);        
        IWebElement passwordInput = driver.FindElement(By.XPath("/html/body/div[5]/div/div[1]/div/form/div[2]/input"));
        passwordInput.SendKeys(password);
        IWebElement loginBtn = driver.FindElement(By.XPath("/html/body/div[5]/div/div[1]/div/form/button"));
        loginBtn.Click();
    }
}