using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Interactions;

namespace NUnitTest_Logiwa_v1._0
{
	public class Inventory : Base
	{

		public static By InventoryScreenButton = By.Id("MainMenuInventoryLink");
		public static By addInventoryButton = By.XPath("//button[contains(.,'Add Inventory')]");
		public static By warehouseButton = By.XPath("//dynamic-platform-form-control[3]/div/dynamic-platform-dropdownlist/kendo-dropdownlist/span/span");
		public static By selectWarehouseButton = By.XPath("//li[contains(.,'Default Warehouse')]");
		public static By addInventoryCombobox = By.XPath(
				"//dynamic-platform-form-control[5]/div/dynamic-platform-dropdownlist/kendo-dropdownlist/span/span/span");
		public static By addInventoryField = By.XPath("//div/span/input");
		public static By addedProduct = By.XPath("//kendo-list/div/ul/li[1]");
		public static By quantityField = By.XPath("//kendo-numerictextbox[@id='quantity']/span/input");
		public static By saveButton = By.XPath("//button[contains(.,'SAVE')]");
		public static By FirstProduct = By.CssSelector("tr:nth-child(1) > td:nth-child(2)");
		public static By addInventoryButtonHover = By.XPath(
				"//platform-root//section//platform-placeholder[@name='system']/platform-content[@placeholder='system']//platform-grid/kendo-grid/div[@role='grid']/table/tbody/tr[1]/td[10]//button[@class='body-fixed inbound']");
		public static By inventoryQuantity = By.XPath("//kendo-numerictextbox[@id='quantity']/span/input");
		public static By addInventoryNoteButton = By.XPath("//span[contains(.,'Add a Note')]");
		public static By addInventoryNote = By.Id("note");
		public static By adjustInventoryButton = By.XPath("//button[contains(.,'Adjust')]");
		public static By RemoveInventoryButton = By.XPath("//button[contains(.,'Remove Inventory')]");
		public static By RemoveInventoryCancelButton = By.XPath("//button[contains(.,'CANCEL')]");
		public static By productCancelYesButton = By.XPath("//button[contains(.,'YES')]");
		public static By RemoveInventoryButtonHover = By.XPath(
				"//platform-root//section//platform-placeholder[@name='system']/platform-content[@placeholder='system']//platform-grid/kendo-grid/div[@role='grid']/table/tbody/tr[@role='row']/td[10]/div/button[3]");

		public static By LocationCombobox = By.XPath("//dynamic-platform-form-control[4]/div/dynamic-platform-dropdownlist/kendo-dropdownlist/span/span");
		public static By AddLocationToCombobox = By.XPath("//div/span/input");
		public static By AddedLocation = By.XPath("//li[contains(.,'Default Warehouse Location')]");


		//hoverover'lar da buton çıkmıyor.


		[Fact]
		public void AddInventoryFromUpperBar()
		{
			WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.UrlContains("/en/wms/dashboard"));
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((InventoryScreenButton)));
			driver.FindElement(InventoryScreenButton).Click();
			Thread.Sleep(3000);
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.UrlContains("/en/wms/inventory/list"));
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((addInventoryButton)));
			driver.FindElement(addInventoryButton).Click();
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible((warehouseButton)));
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((warehouseButton)));
			driver.FindElement(warehouseButton).Click();
			Thread.Sleep(3000);
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible((selectWarehouseButton)));
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((selectWarehouseButton)));
			driver.FindElement(selectWarehouseButton).Click();
			Thread.Sleep(3000);

			//location
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible((LocationCombobox)));
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((LocationCombobox)));
			driver.FindElement(LocationCombobox).Click();


			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible((AddLocationToCombobox)));
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((AddLocationToCombobox)));
			driver.FindElement(AddLocationToCombobox).Click();
			driver.FindElement(AddLocationToCombobox).SendKeys("Default Warehouse Location");

			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible((AddedLocation)));
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((AddedLocation)));
			driver.FindElement(AddedLocation).Click();

			//product
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible((addInventoryCombobox)));
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((addInventoryCombobox)));
			driver.FindElement(addInventoryCombobox).Click();
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible((addInventoryField)));
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((addInventoryField)));
			driver.FindElement(addInventoryField).Click();
			driver.FindElement(addInventoryField).SendKeys("sku");
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible((addedProduct)));
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((addedProduct)));
			driver.FindElement(addedProduct).Click();


			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible((quantityField)));
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((quantityField)));
			driver.FindElement(quantityField).SendKeys("1000");
			Thread.Sleep(1000);
			; wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible((saveButton)));
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((saveButton)));
			driver.FindElement(saveButton).Click();


			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector(".k-notification-content")));
			IWebElement AssertInput = driver.FindElement(By.CssSelector(".k-notification-content"));
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(AssertInput));
			string actualvalue = driver.FindElement(By.CssSelector(".k-notification-content")).Text;
			Assert.True(actualvalue.Contains("You have successfully add inventory."), actualvalue + " doesn't contains");
			Thread.Sleep(3000);
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((InventoryScreenButton)));
		}

		[Fact]
		public void DeleteInventoryFromUpperBar()
		{

			WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.UrlContains("/en/wms/dashboard"));
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((InventoryScreenButton)));
			driver.FindElement(InventoryScreenButton).Click();
			Thread.Sleep(3000);
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.UrlContains("/en/wms/inventory/list"));
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((RemoveInventoryButton)));
			driver.FindElement(RemoveInventoryButton).Click();
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible((warehouseButton)));
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((warehouseButton)));
			driver.FindElement(warehouseButton).Click();
			Thread.Sleep(3000);

			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible((selectWarehouseButton)));
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((selectWarehouseButton)));
			driver.FindElement(selectWarehouseButton).Click();
			Thread.Sleep(3000);

			//location
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible((LocationCombobox)));
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((LocationCombobox)));
			driver.FindElement(LocationCombobox).Click();


			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible((AddLocationToCombobox)));
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((AddLocationToCombobox)));
			driver.FindElement(AddLocationToCombobox).Click();
			driver.FindElement(AddLocationToCombobox).SendKeys("Default Warehouse Location");

			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible((AddedLocation)));
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((AddedLocation)));
			driver.FindElement(AddedLocation).Click();

			//product
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible((addInventoryCombobox)));
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((addInventoryCombobox)));
			driver.FindElement(addInventoryCombobox).Click();
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible((addInventoryField)));
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((addInventoryField)));
			driver.FindElement(addInventoryField).Click();
			driver.FindElement(addInventoryField).SendKeys("sku");
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible((addedProduct)));
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((addedProduct)));
			driver.FindElement(addedProduct).Click();


			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible((quantityField)));
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((quantityField)));
			driver.FindElement(quantityField).SendKeys("1");
			Thread.Sleep(1000);
			; wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible((saveButton)));
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((saveButton)));
			driver.FindElement(saveButton).Click();


			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector(".k-notification-content")));
			IWebElement AssertInput = driver.FindElement(By.CssSelector(".k-notification-content"));
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(AssertInput));
			string actualvalue = driver.FindElement(By.CssSelector(".k-notification-content")).Text;
			Assert.True(actualvalue.Contains("You have successfully remove inventory."), actualvalue + " doesn't contains");
			Thread.Sleep(3000);
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((InventoryScreenButton)));

		}

		[Fact]
		public void DeleteMoreInventoryFromUpperBar()
		{

			WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.UrlContains("/en/wms/dashboard"));
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((InventoryScreenButton)));
			driver.FindElement(InventoryScreenButton).Click();
			Thread.Sleep(3000);
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.UrlContains("/en/wms/inventory/list"));
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((RemoveInventoryButton)));
			driver.FindElement(RemoveInventoryButton).Click();
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible((warehouseButton)));
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((warehouseButton)));
			driver.FindElement(warehouseButton).Click();
			Thread.Sleep(3000);

			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible((selectWarehouseButton)));
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((selectWarehouseButton)));
			driver.FindElement(selectWarehouseButton).Click();
			Thread.Sleep(3000);

			//location
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible((LocationCombobox)));
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((LocationCombobox)));
			driver.FindElement(LocationCombobox).Click();


			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible((AddLocationToCombobox)));
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((AddLocationToCombobox)));
			driver.FindElement(AddLocationToCombobox).Click();
			driver.FindElement(AddLocationToCombobox).SendKeys("Default Warehouse Location");

			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible((AddedLocation)));
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((AddedLocation)));
			driver.FindElement(AddedLocation).Click();

			//product
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible((addInventoryCombobox)));
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((addInventoryCombobox)));
			driver.FindElement(addInventoryCombobox).Click();
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible((addInventoryField)));
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((addInventoryField)));
			driver.FindElement(addInventoryField).Click();
			driver.FindElement(addInventoryField).SendKeys("sku");
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible((addedProduct)));
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((addedProduct)));
			driver.FindElement(addedProduct).Click();


			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible((quantityField)));
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((quantityField)));
			driver.FindElement(quantityField).SendKeys("100000");
			Thread.Sleep(1000);
			; wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible((saveButton)));
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((saveButton)));
			driver.FindElement(saveButton).Click();


			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//span[contains(.,'MyLogiwa does not allow negative inventory. You can not remove more than existing inventory quantity.')]")));
			IWebElement AssertInput = driver.FindElement(By.XPath("//span[contains(.,'MyLogiwa does not allow negative inventory. You can not remove more than existing inventory quantity.')]"));
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(AssertInput));
			string actualvalue = driver.FindElement(By.XPath("//span[contains(.,'MyLogiwa does not allow negative inventory. You can not remove more than existing inventory quantity.')]")).Text;
			Assert.True(actualvalue.Contains("MyLogiwa does not allow negative inventory. You can not remove more than existing inventory quantity."), actualvalue + " doesn't contains");
			Thread.Sleep(3000);
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((InventoryScreenButton)));

		}

		[Fact]
		public void AdjustInventoryPos()
		{

			WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.UrlContains("/en/wms/dashboard"));
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((InventoryScreenButton)));
			driver.FindElement(InventoryScreenButton).Click();
			Thread.Sleep(3000);

			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector("tr:nth-child(1) > td:nth-child(1)")));
			Actions builder = new Actions(driver);
			IWebElement element = driver.FindElement(By.CssSelector("tr:nth-child(1) > td:nth-child(1)"));
			builder.MoveToElement(element).Build().Perform();
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(adjustInventoryButton));
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((adjustInventoryButton)));
			driver.FindElement(adjustInventoryButton).Click();

			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(quantityField));
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((quantityField)));
			driver.FindElement(quantityField).SendKeys("1000");
			Thread.Sleep(1000);
			driver.FindElement(saveButton).Click();
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(FirstProduct));
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((FirstProduct)));

			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector(".k-notification-content")));
			IWebElement AssertInput = driver.FindElement(By.CssSelector(".k-notification-content"));
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(AssertInput));
			string actualvalue = driver.FindElement(By.CssSelector(".k-notification-content")).Text;
			Assert.True(actualvalue.Contains("You have successfully made an adjustment."), actualvalue + " doesn't contains");
			Thread.Sleep(3000);
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((InventoryScreenButton)));

		}

		[Fact]
		public void AdjustInventoryNeg()
		{

			WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.UrlContains("/en/wms/dashboard"));
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((InventoryScreenButton)));
			driver.FindElement(InventoryScreenButton).Click();
			Thread.Sleep(3000);

			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector("tr:nth-child(1) > td:nth-child(1)")));
			Actions builder = new Actions(driver);
			IWebElement element = driver.FindElement(By.CssSelector("tr:nth-child(1) > td:nth-child(1)"));
			builder.MoveToElement(element).Build().Perform();
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(adjustInventoryButton));
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((adjustInventoryButton)));
			driver.FindElement(adjustInventoryButton).Click();

			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(quantityField));
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((quantityField)));
			driver.FindElement(quantityField).SendKeys("1");
			Thread.Sleep(1000);
			driver.FindElement(saveButton).Click();
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(FirstProduct));
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((FirstProduct)));

			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector(".k-notification-content")));
			IWebElement AssertInput = driver.FindElement(By.CssSelector(".k-notification-content"));
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(AssertInput));
			string actualvalue = driver.FindElement(By.CssSelector(".k-notification-content")).Text;
			Assert.True(actualvalue.Contains("You have successfully made an adjustment."), actualvalue + " doesn't contains");
			Thread.Sleep(3000);
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((InventoryScreenButton)));

		}

	}
}
