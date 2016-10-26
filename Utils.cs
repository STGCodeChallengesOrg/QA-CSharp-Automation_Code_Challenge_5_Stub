/*

automation challenge 5 (Use search and get info)
Go to https://www.skiutah.com/members/listing

Write a method that will allow me to pass in 3 string parameters (What, By Resort, Sub Category)

Return the list of the search results by looking at ListingResults-item

Listed below is the sample code stub for running this test.

*/

namespace Automation_Code_Challenge_5_CSharp
{
    [TestClass]
    class Utils : SeleniumWebdriverBaseClass
    {
        [TestMethod]
        // This method is the main method for launching tests
        public void TestLauncher()
        {
            // Verify Page Title
            verifyPageTitle(URL, Expected_Value);
            // Test against Plan Your Trip Search Dialog - Navigation_Menu, Validation_String
            verifyNavigation(Navigation_Menu, Validation_String);
            // Method to search using 3 string parameters - 3 parameters (What, By Resort, Sub-Category)
            searchForDialog(What, By_Resort, Sub_Category);
        }
    }
}
