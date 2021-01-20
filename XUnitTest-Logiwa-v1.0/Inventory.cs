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

namespace XUnitTest_Logiwa_v1._0
{
	public class Inventory : Base
	{
		public static By MainInventoryScreenButton = By.Id("navbarDropdownInventory");
		public static By InventoryScreenButton = By.XPath("(//a[contains(text(),'Inventory')])[2]");
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

		//products 
		public static By ProductsScreenButton = By.XPath("//a[contains(text(),'Products')]");
		public static By createProductButton = By.XPath("//button[contains(.,'Create Product')]");
		public static By sku = By.Name("sku");
		public static By name = By.Name("name");
		public static By packType = By.Id("uomPackTypeName");
		public static By packTypeEmptyArea = By.XPath(
				"/html//platform-root/kendo-popup[@class='k-animation-container k-animation-container-shown']//input");
		public static By createPackType = By.Id("btnCreateProductPackTypeName");
		public static By weightField = By.Id("uomPackTypeWeight");
		public static By initialQuantity = By.Id("quantity");
		public static By addAnImage = By.Id("addNewImageCollapseButton");
		public static By productImage = By.Id("addNewImage");
		public static By productImageAddButton = By.Id("addNewImageInsertButton");
		public static By descriptionArea = By.Id("descriptionCollapseButton");
		public static By EditdesriptArea = By.Name("description");
		public static By addSalesPriceButton = By.Id("salesPriceCollapseButton");
		public static By salesPriceArea = By.Id("salesPrice");
		public static By addPurchaseButton = By.Id("purchasePriceCollapseButton");
		public static By purchasePriceArea = By.Id("purchasePrice");
		public static By addTaxRateButton = By.Id("taxRateCollapseButton");
		public static By taxRateArea = By.Id("taxRate");
		public static By addUPCButton = By.Id("upcCollapseButton");
		public static By uPCArea = By.Id("upc");
		public static By AddProductType = By.Id("productTypeNameCollapseButton");
		public static By ProductTypeArea = By.Id("productTypeName");
		public static By ProductTypeArea2 = By.CssSelector(".k-animation-container .k-list-filter .k-textbox");
		public static By clickProductType = By.Id("btnCreateProductTypeName");
		public static By productSaveButton = By.XPath("//button[contains(.,'SAVE')]");
		public static By deleteProductButton = By.XPath("//button[@id='productGridDeleteButton']/i");
		public static By sureDeleteYes = By.XPath("//button[contains(.,'YES')]");
		public static By editProductButton = By.XPath("//button[contains(.,'Edit')]");

		[Fact]
		public void AddInventoryFromUpperBar()
		{
			using (var driver = new ChromeDriver())
			{
				var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
				Run(driver, wait);

				Guid demoGuid = Guid.NewGuid();

				wait.Until(driver => driver.FindElement(MainInventoryScreenButton).Displayed);
				driver.FindElement(MainInventoryScreenButton).Click();
				wait.Until(driver => driver.FindElement(ProductsScreenButton).Displayed);
				driver.FindElement(ProductsScreenButton).Click();

				Thread.Sleep(3000);

				wait.Until(driver => driver.FindElement(createProductButton).Displayed);
				driver.FindElement(createProductButton).Click();

				wait.Until(driver => driver.FindElement(sku).Displayed);
				driver.FindElement(sku).SendKeys("SKU" + demoGuid);

				wait.Until(driver => driver.FindElement(name).Displayed);
				driver.FindElement(name).SendKeys("Name" + demoGuid);

				wait.Until(driver => driver.FindElement(packType).Displayed);
				driver.FindElement(packType).Click();

				wait.Until(driver => driver.FindElement(packTypeEmptyArea).Displayed);
				driver.FindElement(packTypeEmptyArea).SendKeys("piece" + demoGuid);

				wait.Until(driver => driver.FindElement(createPackType).Displayed);
				driver.FindElement(createPackType).Click();

				wait.Until(driver => driver.FindElement(initialQuantity).Displayed);
				driver.FindElement(initialQuantity).FindElement(By.ClassName("k-input")).SendKeys("0");

				wait.Until(driver => driver.FindElement(AddProductType).Displayed);
				driver.FindElement(AddProductType).Click();

				wait.Until(driver => driver.FindElement(ProductTypeArea).Displayed);
				driver.FindElement(ProductTypeArea).Click();

				wait.Until(driver => driver.FindElement(ProductTypeArea2).Displayed);
				driver.FindElement(ProductTypeArea2).SendKeys("producttype" + demoGuid);

				wait.Until(driver => driver.FindElement(clickProductType).Displayed);
				driver.FindElement(clickProductType).Click();

				wait.Until(driver => driver.FindElement(productSaveButton).Displayed);
				driver.FindElement(productSaveButton).Click();
				Thread.Sleep(3000);
				wait.Until(driver => driver.FindElement(MainInventoryScreenButton).Displayed);

				wait.Until(driver => driver.FindElement(MainInventoryScreenButton).Displayed);
				driver.FindElement(MainInventoryScreenButton).Click();

				Thread.Sleep(1000);

				wait.Until(driver => driver.FindElement(InventoryScreenButton).Displayed);
				driver.FindElement(InventoryScreenButton).Click();

				Thread.Sleep(1000);

				wait.Until(driver => driver.FindElement(addInventoryButton).Displayed);
				driver.FindElement(addInventoryButton).Click();

				Thread.Sleep(1000);

				wait.Until(driver => driver.FindElement(warehouseButton).Displayed);
				driver.FindElement(warehouseButton).Click();

				Thread.Sleep(3000);

				wait.Until(driver => driver.FindElement(selectWarehouseButton).Displayed);
				driver.FindElement(selectWarehouseButton).Click();
				Thread.Sleep(3000);

				//location
				/*wait.Until(driver => driver.FindElement(LocationCombobox).Displayed);
				 driver.FindElement(LocationCombobox).Click();

				wait.Until(driver => driver.FindElement(AddLocationToCombobox).Displayed);
				driver.FindElement(AddLocationToCombobox).Click();
				driver.FindElement(AddLocationToCombobox).SendKeys("PrimaryLoc");

				wait.Until(driver => driver.FindElement(AddedLocation).Displayed);
				driver.FindElement(AddedLocation).Click();*/

				//product
				wait.Until(driver => driver.FindElement(addInventoryCombobox).Displayed);
				driver.FindElement(addInventoryCombobox).Click();

				wait.Until(driver => driver.FindElement(addInventoryField).Displayed);
				driver.FindElement(addInventoryField).Click();
				driver.FindElement(addInventoryField).SendKeys("sku");

				wait.Until(driver => driver.FindElement(addedProduct).Displayed);
				driver.FindElement(addedProduct).Click();

				wait.Until(driver => driver.FindElement(quantityField).Displayed);
				driver.FindElement(quantityField).SendKeys("1000");

				Thread.Sleep(1000);
				wait.Until(driver => driver.FindElement(saveButton).Displayed);
				driver.FindElement(saveButton).Click();

				wait.Until(driver => driver.FindElement(By.CssSelector(".k-notification-wrap")).Displayed);
				IWebElement AssertInput = driver.FindElement(By.CssSelector(".k-notification-wrap"));

				string actualvalue = driver.FindElement(By.CssSelector(".k-notification-wrap")).Text;
				Assert.True(actualvalue.Contains("You have successfully add inventory."), actualvalue + " doesn't contains");

				Thread.Sleep(3000);
				wait.Until(driver => driver.FindElement(MainInventoryScreenButton).Displayed);
			}
		}


		[Fact]
		public void DeleteInventoryFromUpperBar()
		{
			using (var driver = new ChromeDriver())
			{

				var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
				Run(driver, wait);

				Guid demoGuid = Guid.NewGuid();

				wait.Until(driver => driver.FindElement(MainInventoryScreenButton).Displayed);
				driver.FindElement(MainInventoryScreenButton).Click();
				wait.Until(driver => driver.FindElement(ProductsScreenButton).Displayed);
				driver.FindElement(ProductsScreenButton).Click();

				Thread.Sleep(3000);

				wait.Until(driver => driver.FindElement(createProductButton).Displayed);
				driver.FindElement(createProductButton).Click();

				wait.Until(driver => driver.FindElement(sku).Displayed);
				driver.FindElement(sku).SendKeys("SKU" + demoGuid);

				wait.Until(driver => driver.FindElement(name).Displayed);
				driver.FindElement(name).SendKeys("Name" + demoGuid);

				wait.Until(driver => driver.FindElement(packType).Displayed);
				driver.FindElement(packType).Click();

				wait.Until(driver => driver.FindElement(packTypeEmptyArea).Displayed);
				driver.FindElement(packTypeEmptyArea).SendKeys("piece" + demoGuid);

				wait.Until(driver => driver.FindElement(createPackType).Displayed);
				driver.FindElement(createPackType).Click();

				wait.Until(driver => driver.FindElement(initialQuantity).Displayed);
				driver.FindElement(initialQuantity).FindElement(By.ClassName("k-input")).SendKeys("10");

				wait.Until(driver => driver.FindElement(AddProductType).Displayed);
				driver.FindElement(AddProductType).Click();

				wait.Until(driver => driver.FindElement(ProductTypeArea).Displayed);
				driver.FindElement(ProductTypeArea).Click();

				wait.Until(driver => driver.FindElement(ProductTypeArea2).Displayed);
				driver.FindElement(ProductTypeArea2).SendKeys("producttype" + demoGuid);

				wait.Until(driver => driver.FindElement(clickProductType).Displayed);
				driver.FindElement(clickProductType).Click();

				wait.Until(driver => driver.FindElement(productSaveButton).Displayed);
				driver.FindElement(productSaveButton).Click();
				Thread.Sleep(3000);
				wait.Until(driver => driver.FindElement(MainInventoryScreenButton).Displayed);
				wait.Until(driver => driver.FindElement(MainInventoryScreenButton).Displayed);
				driver.FindElement(MainInventoryScreenButton).Click();

				Thread.Sleep(1000);

				wait.Until(driver => driver.FindElement(InventoryScreenButton).Displayed);
				driver.FindElement(InventoryScreenButton).Click();

				Thread.Sleep(3000);

				wait.Until(driver => driver.FindElement(RemoveInventoryButton).Displayed);
				driver.FindElement(RemoveInventoryButton).Click();

				wait.Until(driver => driver.FindElement(warehouseButton).Displayed);
				driver.FindElement(warehouseButton).Click();

				Thread.Sleep(3000);

				wait.Until(driver => driver.FindElement(selectWarehouseButton).Displayed);
				driver.FindElement(selectWarehouseButton).Click();
				Thread.Sleep(3000);

				//location
				/*wait.Until(driver => driver.FindElement(LocationCombobox).Displayed);
				 driver.FindElement(LocationCombobox).Click();

				wait.Until(driver => driver.FindElement(AddLocationToCombobox).Displayed);
				driver.FindElement(AddLocationToCombobox).Click();
				driver.FindElement(AddLocationToCombobox).SendKeys("PrimaryLoc");

				wait.Until(driver => driver.FindElement(AddedLocation).Displayed);
				driver.FindElement(AddedLocation).Click();*/

				//product
				wait.Until(driver => driver.FindElement(addInventoryCombobox).Displayed);
				driver.FindElement(addInventoryCombobox).Click();

				wait.Until(driver => driver.FindElement(addInventoryField).Displayed);
				driver.FindElement(addInventoryField).Click();
				driver.FindElement(addInventoryField).SendKeys("sku");

				wait.Until(driver => driver.FindElement(addedProduct).Displayed);
				driver.FindElement(addedProduct).Click();

				wait.Until(driver => driver.FindElement(quantityField).Displayed);
				driver.FindElement(quantityField).SendKeys("1");
				Thread.Sleep(1000);

				wait.Until(driver => driver.FindElement(saveButton).Displayed);
				driver.FindElement(saveButton).Click();

				wait.Until(driver => driver.FindElement(By.CssSelector(".k-notification-wrap")).Displayed);
				IWebElement AssertInput = driver.FindElement(By.CssSelector(".k-notification-wrap"));

				string actualvalue = driver.FindElement(By.CssSelector(".k-notification-wrap")).Text;
				Assert.True(actualvalue.Contains("You have successfully remove inventory."), actualvalue + " doesn't contains");

				Thread.Sleep(3000);
				wait.Until(driver => driver.FindElement(MainInventoryScreenButton).Displayed);

			}
		}

		[Fact]
		public void DeleteMoreInventoryFromUpperBar()
		{

			using (var driver = new ChromeDriver())
			{

				var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
				Run(driver, wait);

				Guid demoGuid = Guid.NewGuid();

				wait.Until(driver => driver.FindElement(MainInventoryScreenButton).Displayed);
				driver.FindElement(MainInventoryScreenButton).Click();
				wait.Until(driver => driver.FindElement(ProductsScreenButton).Displayed);
				driver.FindElement(ProductsScreenButton).Click();

				Thread.Sleep(3000);

				wait.Until(driver => driver.FindElement(createProductButton).Displayed);
				driver.FindElement(createProductButton).Click();

				wait.Until(driver => driver.FindElement(sku).Displayed);
				driver.FindElement(sku).SendKeys("SKU" + demoGuid);

				wait.Until(driver => driver.FindElement(name).Displayed);
				driver.FindElement(name).SendKeys("Name" + demoGuid);

				wait.Until(driver => driver.FindElement(packType).Displayed);
				driver.FindElement(packType).Click();

				wait.Until(driver => driver.FindElement(packTypeEmptyArea).Displayed);
				driver.FindElement(packTypeEmptyArea).SendKeys("piece" + demoGuid);

				wait.Until(driver => driver.FindElement(createPackType).Displayed);
				driver.FindElement(createPackType).Click();

				wait.Until(driver => driver.FindElement(initialQuantity).Displayed);
				driver.FindElement(initialQuantity).FindElement(By.ClassName("k-input")).SendKeys("10");

				wait.Until(driver => driver.FindElement(AddProductType).Displayed);
				driver.FindElement(AddProductType).Click();

				wait.Until(driver => driver.FindElement(ProductTypeArea).Displayed);
				driver.FindElement(ProductTypeArea).Click();

				wait.Until(driver => driver.FindElement(ProductTypeArea2).Displayed);
				driver.FindElement(ProductTypeArea2).SendKeys("producttype" + demoGuid);

				wait.Until(driver => driver.FindElement(clickProductType).Displayed);
				driver.FindElement(clickProductType).Click();

				wait.Until(driver => driver.FindElement(productSaveButton).Displayed);
				driver.FindElement(productSaveButton).Click();
				Thread.Sleep(3000);
				wait.Until(driver => driver.FindElement(MainInventoryScreenButton).Displayed);
				wait.Until(driver => driver.FindElement(MainInventoryScreenButton).Displayed);
				driver.FindElement(MainInventoryScreenButton).Click();

				Thread.Sleep(1000);

				wait.Until(driver => driver.FindElement(InventoryScreenButton).Displayed);
				driver.FindElement(InventoryScreenButton).Click();

				Thread.Sleep(3000);

				wait.Until(driver => driver.FindElement(RemoveInventoryButton).Displayed);
				driver.FindElement(RemoveInventoryButton).Click();

				wait.Until(driver => driver.FindElement(warehouseButton).Displayed);
				driver.FindElement(warehouseButton).Click();

				Thread.Sleep(3000);

				wait.Until(driver => driver.FindElement(selectWarehouseButton).Displayed);
				driver.FindElement(selectWarehouseButton).Click();
				Thread.Sleep(3000);

				//location
				/*wait.Until(driver => driver.FindElement(LocationCombobox).Displayed);
				 driver.FindElement(LocationCombobox).Click();

				wait.Until(driver => driver.FindElement(AddLocationToCombobox).Displayed);
				driver.FindElement(AddLocationToCombobox).Click();
				driver.FindElement(AddLocationToCombobox).SendKeys("PrimaryLoc");

				wait.Until(driver => driver.FindElement(AddedLocation).Displayed);
				driver.FindElement(AddedLocation).Click();*/

				//product
				wait.Until(driver => driver.FindElement(addInventoryCombobox).Displayed);
				driver.FindElement(addInventoryCombobox).Click();

				wait.Until(driver => driver.FindElement(addInventoryField).Displayed);
				driver.FindElement(addInventoryField).Click();
				driver.FindElement(addInventoryField).SendKeys("sku");

				wait.Until(driver => driver.FindElement(addedProduct).Displayed);
				driver.FindElement(addedProduct).Click();

				wait.Until(driver => driver.FindElement(quantityField).Displayed);
				driver.FindElement(quantityField).SendKeys("11");
				Thread.Sleep(1000);

				wait.Until(driver => driver.FindElement(saveButton).Displayed);
				driver.FindElement(saveButton).Click();

				wait.Until(driver => driver.FindElement(By.CssSelector(".k-notification-wrap")).Displayed);
				IWebElement AssertInput = driver.FindElement(By.CssSelector(".k-notification-wrap"));

				string actualvalue = driver.FindElement(By.CssSelector(".k-notification-wrap")).Text;
				Assert.True(actualvalue.Contains("You have successfully remove inventory."), actualvalue + " doesn't contains");

				Thread.Sleep(3000);
				wait.Until(driver => driver.FindElement(MainInventoryScreenButton).Displayed);

			}

		}

		[Fact]
		public void AdjustInventoryPos()
		{

			using (var driver = new ChromeDriver())
			{

				var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
				Run(driver, wait);

				Guid demoGuid = Guid.NewGuid();

				wait.Until(driver => driver.FindElement(MainInventoryScreenButton).Displayed);
				driver.FindElement(MainInventoryScreenButton).Click();
				wait.Until(driver => driver.FindElement(ProductsScreenButton).Displayed);
				driver.FindElement(ProductsScreenButton).Click();

				Thread.Sleep(3000);

				wait.Until(driver => driver.FindElement(createProductButton).Displayed);
				driver.FindElement(createProductButton).Click();

				wait.Until(driver => driver.FindElement(sku).Displayed);
				driver.FindElement(sku).SendKeys("SKU" + demoGuid);

				wait.Until(driver => driver.FindElement(name).Displayed);
				driver.FindElement(name).SendKeys("Name" + demoGuid);

				wait.Until(driver => driver.FindElement(packType).Displayed);
				driver.FindElement(packType).Click();

				wait.Until(driver => driver.FindElement(packTypeEmptyArea).Displayed);
				driver.FindElement(packTypeEmptyArea).SendKeys("piece" + demoGuid);

				wait.Until(driver => driver.FindElement(createPackType).Displayed);
				driver.FindElement(createPackType).Click();

				wait.Until(driver => driver.FindElement(initialQuantity).Displayed);
				driver.FindElement(initialQuantity).FindElement(By.ClassName("k-input")).SendKeys("10");

				wait.Until(driver => driver.FindElement(AddProductType).Displayed);
				driver.FindElement(AddProductType).Click();

				wait.Until(driver => driver.FindElement(ProductTypeArea).Displayed);
				driver.FindElement(ProductTypeArea).Click();

				wait.Until(driver => driver.FindElement(ProductTypeArea2).Displayed);
				driver.FindElement(ProductTypeArea2).SendKeys("producttype" + demoGuid);

				wait.Until(driver => driver.FindElement(clickProductType).Displayed);
				driver.FindElement(clickProductType).Click();

				wait.Until(driver => driver.FindElement(productSaveButton).Displayed);
				driver.FindElement(productSaveButton).Click();
				Thread.Sleep(3000);
				wait.Until(driver => driver.FindElement(MainInventoryScreenButton).Displayed);
				wait.Until(driver => driver.FindElement(MainInventoryScreenButton).Displayed);
				driver.FindElement(MainInventoryScreenButton).Click();

				Thread.Sleep(1000);

				wait.Until(driver => driver.FindElement(InventoryScreenButton).Displayed);
				driver.FindElement(InventoryScreenButton).Click();

				Thread.Sleep(3000);

				wait.Until(driver => driver.FindElement(By.CssSelector("tr:nth-child(1) > td:nth-child(1)")).Displayed);
				Actions builder = new Actions(driver);
				IWebElement element = driver.FindElement(By.CssSelector("tr:nth-child(1) > td:nth-child(1)"));

				builder.MoveToElement(element).Build().Perform();

				wait.Until(driver => driver.FindElement(adjustInventoryButton).Displayed);

				driver.FindElement(adjustInventoryButton).Click();

				wait.Until(driver => driver.FindElement(quantityField).Displayed);
				driver.FindElement(quantityField).SendKeys("1000");

				Thread.Sleep(1000);

				driver.FindElement(saveButton).Click();

				wait.Until(driver => driver.FindElement(FirstProduct).Displayed);

				wait.Until(driver => driver.FindElement(By.CssSelector(".k-notification-wrap")).Displayed);

				IWebElement AssertInput = driver.FindElement(By.CssSelector(".k-notification-wrap"));

				string actualvalue = driver.FindElement(By.CssSelector(".k-notification-wrap")).Text;
				Assert.True(actualvalue.Contains("You have successfully made an adjustment."), actualvalue + " doesn't contains");

				Thread.Sleep(3000);

				wait.Until(driver => driver.FindElement(MainInventoryScreenButton).Displayed);

			}
		}

		[Fact]
		public void AdjustInventoryNeg()
		{

			using (var driver = new ChromeDriver())
			{

				var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
				Run(driver, wait);

				Guid demoGuid = Guid.NewGuid();

				wait.Until(driver => driver.FindElement(MainInventoryScreenButton).Displayed);
				driver.FindElement(MainInventoryScreenButton).Click();
				wait.Until(driver => driver.FindElement(ProductsScreenButton).Displayed);
				driver.FindElement(ProductsScreenButton).Click();

				Thread.Sleep(3000);

				wait.Until(driver => driver.FindElement(createProductButton).Displayed);
				driver.FindElement(createProductButton).Click();

				wait.Until(driver => driver.FindElement(sku).Displayed);
				driver.FindElement(sku).SendKeys("SKU" + demoGuid);

				wait.Until(driver => driver.FindElement(name).Displayed);
				driver.FindElement(name).SendKeys("Name" + demoGuid);

				wait.Until(driver => driver.FindElement(packType).Displayed);
				driver.FindElement(packType).Click();

				wait.Until(driver => driver.FindElement(packTypeEmptyArea).Displayed);
				driver.FindElement(packTypeEmptyArea).SendKeys("piece" + demoGuid);

				wait.Until(driver => driver.FindElement(createPackType).Displayed);
				driver.FindElement(createPackType).Click();

				wait.Until(driver => driver.FindElement(initialQuantity).Displayed);
				driver.FindElement(initialQuantity).FindElement(By.ClassName("k-input")).SendKeys("10");

				wait.Until(driver => driver.FindElement(AddProductType).Displayed);
				driver.FindElement(AddProductType).Click();

				wait.Until(driver => driver.FindElement(ProductTypeArea).Displayed);
				driver.FindElement(ProductTypeArea).Click();

				wait.Until(driver => driver.FindElement(ProductTypeArea2).Displayed);
				driver.FindElement(ProductTypeArea2).SendKeys("producttype" + demoGuid);

				wait.Until(driver => driver.FindElement(clickProductType).Displayed);
				driver.FindElement(clickProductType).Click();

				wait.Until(driver => driver.FindElement(productSaveButton).Displayed);
				driver.FindElement(productSaveButton).Click();
				Thread.Sleep(3000);
				wait.Until(driver => driver.FindElement(MainInventoryScreenButton).Displayed);
				wait.Until(driver => driver.FindElement(MainInventoryScreenButton).Displayed);
				driver.FindElement(MainInventoryScreenButton).Click();

				Thread.Sleep(1000);

				wait.Until(driver => driver.FindElement(InventoryScreenButton).Displayed);
				driver.FindElement(InventoryScreenButton).Click();

				Thread.Sleep(3000);

				wait.Until(driver => driver.FindElement(By.CssSelector("tr:nth-child(1) > td:nth-child(1)")).Displayed);
				Actions builder = new Actions(driver);
				IWebElement element = driver.FindElement(By.CssSelector("tr:nth-child(1) > td:nth-child(1)"));

				builder.MoveToElement(element).Build().Perform();

				wait.Until(driver => driver.FindElement(adjustInventoryButton).Displayed);

				driver.FindElement(adjustInventoryButton).Click();

				wait.Until(driver => driver.FindElement(quantityField).Displayed);
				driver.FindElement(quantityField).SendKeys("1");

				Thread.Sleep(1000);

				driver.FindElement(saveButton).Click();

				wait.Until(driver => driver.FindElement(FirstProduct).Displayed);

				wait.Until(driver => driver.FindElement(By.CssSelector(".k-notification-wrap")).Displayed);

				IWebElement AssertInput = driver.FindElement(By.CssSelector(".k-notification-wrap"));

				string actualvalue = driver.FindElement(By.CssSelector(".k-notification-wrap")).Text;
				Assert.True(actualvalue.Contains("You have successfully made an adjustment."), actualvalue + " doesn't contains");

				Thread.Sleep(3000);

				wait.Until(driver => driver.FindElement(MainInventoryScreenButton).Displayed);

			}
		}
	}
}

				
