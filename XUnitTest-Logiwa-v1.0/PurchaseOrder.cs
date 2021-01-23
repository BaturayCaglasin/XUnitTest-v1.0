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

//Delete Purchase Order harici ok. Delete PO için zülfü'den buton geliştirmesi lazım

namespace XUnitTest_Logiwa_v1._0
{
	public class PurchaseOrder : Base
	{

		//PURCHASE ORDER

		public static By PurchaseOrderScreenButton = By.Id("MainMenuPurchaseOrderLink");
		public static By vendorList = By.XPath("//a[contains(.,'Vendor list')]");
		public static By createVendor = By.XPath("//button[contains(.,'Create Vendor')]");
		public static By companyNickname = By.Id("displayName");
		public static By companyName = By.Id("officialIdentity");
		public static By addressName = By.Id("addressName");
		public static By addressLine1 = By.Id("addressLine1");
		public static By addressLine2 = By.Id("addressLine2");
		public static By postalCode = By.Id("postalCode");
		public static By city = By.Id("city");
		public static By saveVendor = By.XPath("//button[contains(.,'SAVE')]");
		public static By createPurchaseOrderButton = By.XPath("//button[contains(.,'Create Purchase Order')]");
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

		public static By clickAddVendorInformation = By.XPath("//button[contains(.,'Add Vendor Information')]");
		public static By addANewVendorButton = By.XPath("//button[contains(.,'Add New Vendor')]");
		public static By addOrderDetails = By.XPath("//button[contains(.,'Add Order Details')]");
		public static By poOrderCode = By.Name("code");
		public static By orderTypeSection = By
				.XPath("//kendo-dropdownlist[@id='purchaseOrderTypeName']//span[@class='k-input']");
		public static By orderTypeArea = By.XPath(
				"/html//platform-root/kendo-popup[@class='k-animation-container k-animation-container-shown']//input");
		public static By orderTypeAdd = By.XPath("//button[contains(.,'Create New Purchase Order Type')]");
		public static By confirmPurchaseOrder = By.XPath("//button[contains(.,'Confirm Purchase Order')]");
		public static By confirmandPlaceOrder = By.XPath("//button[contains(.,'Confirm and Place Order')]");
		public static By quantityElement = By.XPath(
				"//div[@id='collapseOne']//platform-purchase-order-product-form-view//platform-grid/kendo-grid/div[@role='grid']//tbody/tr[@role='row']/td[4]//kendo-numerictextbox//input[@role='spinbutton']");
		public static By pricePerItemElement = By.XPath(
				"//div[@id='collapseOne']//platform-purchase-order-product-form-view//platform-grid/kendo-grid/div[@role='grid']//tbody/tr[@role='row']/td[5]//kendo-numerictextbox//input[@role='spinbutton']");
		public static By showDetails2 = By.XPath("//div[@id='headingThree']/div/div[2]/button");
		public static By poCode = By.Id("code");
		public static By saveApplyChanges = By.XPath("//div[2]/div[2]/button");
		public static By poEditBTN = By.XPath("//button[contains(.,'Edit')]");
		public static By poDeleteBTN = By.XPath("//button[contains(.,'Delete')]");
		public static By poCancelBTN = By.XPath("//button[contains(.,'Cancel Order')]");
		public static By poReceiptBTN = By.XPath("//button[contains(.,'Receive Order')]");
		public static By clickDBTN = By.XPath("//button[contains(.,'YES')]");
		public static By clickWarehouseButton = By
				.XPath("//dynamic-platform-form-control[3]/div/dynamic-platform-dropdownlist/kendo-dropdownlist/span/span");
		public static By chooseaWarehouse = By.XPath("//li[contains(.,'Default Warehouse')]");
		public static By addProducts = By.XPath("//button[contains(.,'Add Products')]");
		public static By sureDeleteYes = By.XPath("//button[contains(.,'YES')]");

		[Fact]
		public void CreatePurchaseOrder()
		{
			using (var driver = new ChromeDriver())
			{
				var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
				Run(driver, wait);

				Guid demoGuid = Guid.NewGuid();

				wait.Until(driver => driver.FindElement(PurchaseOrderScreenButton).Displayed);
				driver.FindElement(PurchaseOrderScreenButton).Click();

				Thread.Sleep(3000);

				wait.Until(driver => driver.FindElement(createPurchaseOrderButton).Displayed);
				driver.FindElement(createPurchaseOrderButton).Click();

				Thread.Sleep(3000);

				//first step
				
				wait.Until(driver => driver.FindElement(clickWarehouseButton).Displayed);
				driver.FindElement(clickWarehouseButton).Click();
				Thread.Sleep(1000);


				wait.Until(driver => driver.FindElement(chooseaWarehouse).Displayed);
				driver.FindElement(chooseaWarehouse).Click();
				Thread.Sleep(1000);

				wait.Until(driver => driver.FindElement(poOrderCode).Displayed);
				driver.FindElement(poOrderCode).SendKeys("PO" + demoGuid);
				Thread.Sleep(1000);

				wait.Until(driver => driver.FindElement(orderTypeSection).Displayed);
				driver.FindElement(orderTypeSection).Click();
				Thread.Sleep(1000);

				wait.Until(driver => driver.FindElement(orderTypeArea).Displayed);
				driver.FindElement(orderTypeArea).SendKeys("OrderType" + demoGuid);
				Thread.Sleep(1000);
				wait.Until(driver => driver.FindElement(orderTypeAdd).Displayed);
				driver.FindElement(orderTypeAdd).Click();
				Thread.Sleep(1000);

				//Products step

				wait.Until(driver => driver.FindElement(addProducts).Displayed);
				driver.FindElement(addProducts).Click();
				Thread.Sleep(1000);

				wait.Until(driver => driver.FindElement(createProductButton).Displayed);
				driver.FindElement(createProductButton).Click();
				Thread.Sleep(1000);

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

				wait.Until(driver => driver.FindElement(clickAddVendorInformation).Displayed);
				driver.FindElement(clickAddVendorInformation).Click();
				Thread.Sleep(3000);

				//vendor step

				wait.Until(driver => driver.FindElement(addANewVendorButton).Displayed);
				driver.FindElement(addANewVendorButton).Click();

				wait.Until(driver => driver.FindElement(companyNickname).Displayed);
				driver.FindElement(companyNickname).SendKeys("c" + demoGuid);

				wait.Until(driver => driver.FindElement(companyName).Displayed);
				driver.FindElement(companyName).SendKeys("c" + demoGuid);

				driver.FindElement(addressName).SendKeys("ad" + demoGuid);
				driver.FindElement(addressLine1).SendKeys("ad1" + demoGuid);
				driver.FindElement(addressLine2).SendKeys("ad2" + demoGuid);
				driver.FindElement(postalCode).SendKeys("p" + demoGuid);
				driver.FindElement(city).SendKeys("ci");

				wait.Until(driver => driver.FindElement(saveVendor).Displayed);
				driver.FindElement(saveVendor).Click();

				Thread.Sleep(2000);

				wait.Until(driver => driver.FindElement(confirmPurchaseOrder).Displayed);
				driver.FindElement(confirmPurchaseOrder).Click();

				Thread.Sleep(2000);

				wait.Until(driver => driver.FindElement(confirmandPlaceOrder).Displayed);
				driver.FindElement(confirmandPlaceOrder).Click();

				
				Thread.Sleep(4000);


				wait.Until(driver => driver.FindElement(By.XPath("//h2[contains(.,'What can you do next?')]")).Displayed);
				IWebElement AssertInput = driver.FindElement(By.XPath("//h2[contains(.,'What can you do next?')]"));

				string actualvalue = driver.FindElement(By.XPath("//h2[contains(.,'What can you do next?')]")).Text;
				Assert.True(actualvalue.Contains("What can you do next?"), actualvalue + " doesn't contains");


				Thread.Sleep(2000);
				wait.Until(driver => driver.FindElement(PurchaseOrderScreenButton).Displayed);
			}
		}


		[Fact]
		public void EditPurchaseOrder()
		{
			using (var driver = new ChromeDriver())
			{

				var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
				Run(driver, wait);

				Guid demoGuid = Guid.NewGuid();

				wait.Until(driver => driver.FindElement(PurchaseOrderScreenButton).Displayed);
				driver.FindElement(PurchaseOrderScreenButton).Click();

				Thread.Sleep(3000);

				wait.Until(driver => driver.FindElement(createPurchaseOrderButton).Displayed);
				driver.FindElement(createPurchaseOrderButton).Click();

				Thread.Sleep(3000);

				//first step

				wait.Until(driver => driver.FindElement(clickWarehouseButton).Displayed);
				driver.FindElement(clickWarehouseButton).Click();
				Thread.Sleep(1000);


				wait.Until(driver => driver.FindElement(chooseaWarehouse).Displayed);
				driver.FindElement(chooseaWarehouse).Click();
				Thread.Sleep(1000);

				wait.Until(driver => driver.FindElement(poOrderCode).Displayed);
				driver.FindElement(poOrderCode).SendKeys("PO" + demoGuid);
				Thread.Sleep(1000);

				wait.Until(driver => driver.FindElement(orderTypeSection).Displayed);
				driver.FindElement(orderTypeSection).Click();
				Thread.Sleep(1000);

				wait.Until(driver => driver.FindElement(orderTypeArea).Displayed);
				driver.FindElement(orderTypeArea).SendKeys("OrderType" + demoGuid);
				Thread.Sleep(1000);
				wait.Until(driver => driver.FindElement(orderTypeAdd).Displayed);
				driver.FindElement(orderTypeAdd).Click();
				Thread.Sleep(1000);

				//Products step

				wait.Until(driver => driver.FindElement(addProducts).Displayed);
				driver.FindElement(addProducts).Click();
				Thread.Sleep(1000);

				wait.Until(driver => driver.FindElement(createProductButton).Displayed);
				driver.FindElement(createProductButton).Click();
				Thread.Sleep(1000);

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

				wait.Until(driver => driver.FindElement(clickAddVendorInformation).Displayed);
				driver.FindElement(clickAddVendorInformation).Click();
				Thread.Sleep(3000);

				//vendor step

				wait.Until(driver => driver.FindElement(addANewVendorButton).Displayed);
				driver.FindElement(addANewVendorButton).Click();

				wait.Until(driver => driver.FindElement(companyNickname).Displayed);
				driver.FindElement(companyNickname).SendKeys("c" + demoGuid);

				wait.Until(driver => driver.FindElement(companyName).Displayed);
				driver.FindElement(companyName).SendKeys("c" + demoGuid);

				driver.FindElement(addressName).SendKeys("ad" + demoGuid);
				driver.FindElement(addressLine1).SendKeys("ad1" + demoGuid);
				driver.FindElement(addressLine2).SendKeys("ad2" + demoGuid);
				driver.FindElement(postalCode).SendKeys("p" + demoGuid);
				driver.FindElement(city).SendKeys("ci");

				wait.Until(driver => driver.FindElement(saveVendor).Displayed);
				driver.FindElement(saveVendor).Click();

				Thread.Sleep(2000);

				wait.Until(driver => driver.FindElement(confirmPurchaseOrder).Displayed);
				driver.FindElement(confirmPurchaseOrder).Click();

				Thread.Sleep(2000);

				wait.Until(driver => driver.FindElement(confirmandPlaceOrder).Displayed);
				driver.FindElement(confirmandPlaceOrder).Click();

				Thread.Sleep(4000);
				
				//Edit Part

				wait.Until(driver => driver.FindElement(PurchaseOrderScreenButton).Displayed);
				driver.FindElement(PurchaseOrderScreenButton).Click();

				Thread.Sleep(3000);

				wait.Until(driver => driver.FindElement(By.CssSelector("tr:nth-child(1) > td:nth-child(3)")).Displayed);
				Actions builder = new Actions(driver);
				IWebElement element = driver.FindElement(By.CssSelector("tr:nth-child(1) > td:nth-child(3)"));
				builder.MoveToElement(element).Build().Perform();

				wait.Until(driver => driver.FindElement(poEditBTN).Displayed);
				driver.FindElement(poEditBTN).Click();
				
				Thread.Sleep(2000);

				wait.Until(driver => driver.FindElement(quantityElement).Displayed);
				driver.FindElement(quantityElement).SendKeys("10");

				wait.Until(driver => driver.FindElement(pricePerItemElement).Displayed);
				driver.FindElement(pricePerItemElement).SendKeys("10");

				wait.Until(driver => driver.FindElement(saveApplyChanges).Displayed);
				driver.FindElement(saveApplyChanges).Click();

				Thread.Sleep(5000);


				wait.Until(driver => driver.FindElement(By.CssSelector(".k-notification-wrap")).Displayed);

				IWebElement AssertInput = driver.FindElement(By.CssSelector(".k-notification-wrap"));

				string actualvalue = driver.FindElement(By.CssSelector(".k-notification-wrap")).Text;
				Assert.True(actualvalue.Contains("You have successfully edited a purchase order."), actualvalue + " doesn't contains");

				Thread.Sleep(3000);

				wait.Until(driver => driver.FindElement(PurchaseOrderScreenButton).Displayed);

			}
		}

		[Fact]
		public void DeletePurchaseOrder()
		{
			using (var driver = new ChromeDriver())
			{
				var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
				Run(driver, wait);

				Guid demoGuid = Guid.NewGuid();
				wait.Until(driver => driver.FindElement(PurchaseOrderScreenButton).Displayed);
				driver.FindElement(PurchaseOrderScreenButton).Click();

				Thread.Sleep(3000);

				wait.Until(driver => driver.FindElement(createPurchaseOrderButton).Displayed);
				driver.FindElement(createPurchaseOrderButton).Click();

				Thread.Sleep(3000);

				//first step

				wait.Until(driver => driver.FindElement(clickWarehouseButton).Displayed);
				driver.FindElement(clickWarehouseButton).Click();
				Thread.Sleep(1000);


				wait.Until(driver => driver.FindElement(chooseaWarehouse).Displayed);
				driver.FindElement(chooseaWarehouse).Click();
				Thread.Sleep(1000);

				wait.Until(driver => driver.FindElement(poOrderCode).Displayed);
				driver.FindElement(poOrderCode).SendKeys("PO" + demoGuid);
				Thread.Sleep(1000);

				wait.Until(driver => driver.FindElement(orderTypeSection).Displayed);
				driver.FindElement(orderTypeSection).Click();
				Thread.Sleep(1000);

				wait.Until(driver => driver.FindElement(orderTypeArea).Displayed);
				driver.FindElement(orderTypeArea).SendKeys("OrderType" + demoGuid);
				Thread.Sleep(1000);
				wait.Until(driver => driver.FindElement(orderTypeAdd).Displayed);
				driver.FindElement(orderTypeAdd).Click();
				Thread.Sleep(1000);

				//Products step

				wait.Until(driver => driver.FindElement(addProducts).Displayed);
				driver.FindElement(addProducts).Click();
				Thread.Sleep(1000);

				wait.Until(driver => driver.FindElement(createProductButton).Displayed);
				driver.FindElement(createProductButton).Click();
				Thread.Sleep(1000);

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

				wait.Until(driver => driver.FindElement(clickAddVendorInformation).Displayed);
				driver.FindElement(clickAddVendorInformation).Click();
				Thread.Sleep(3000);

				//vendor step

				wait.Until(driver => driver.FindElement(addANewVendorButton).Displayed);
				driver.FindElement(addANewVendorButton).Click();

				wait.Until(driver => driver.FindElement(companyNickname).Displayed);
				driver.FindElement(companyNickname).SendKeys("c" + demoGuid);

				wait.Until(driver => driver.FindElement(companyName).Displayed);
				driver.FindElement(companyName).SendKeys("c" + demoGuid);

				driver.FindElement(addressName).SendKeys("ad" + demoGuid);
				driver.FindElement(addressLine1).SendKeys("ad1" + demoGuid);
				driver.FindElement(addressLine2).SendKeys("ad2" + demoGuid);
				driver.FindElement(postalCode).SendKeys("p" + demoGuid);
				driver.FindElement(city).SendKeys("ci");

				wait.Until(driver => driver.FindElement(saveVendor).Displayed);
				driver.FindElement(saveVendor).Click();

				Thread.Sleep(2000);

				wait.Until(driver => driver.FindElement(confirmPurchaseOrder).Displayed);
				driver.FindElement(confirmPurchaseOrder).Click();

				Thread.Sleep(2000);

				wait.Until(driver => driver.FindElement(confirmandPlaceOrder).Displayed);
				driver.FindElement(confirmandPlaceOrder).Click();

				Thread.Sleep(4000);

				//Delete Part 
				wait.Until(driver => driver.FindElement(PurchaseOrderScreenButton).Displayed);
				driver.FindElement(PurchaseOrderScreenButton).Click();

				Thread.Sleep(3000);

				wait.Until(driver => driver.FindElement(By.CssSelector("tr:nth-child(1) > td:nth-child(3)")).Displayed);
				Actions builder = new Actions(driver);
				IWebElement element = driver.FindElement(By.CssSelector("tr:nth-child(1) > td:nth-child(3)"));
				builder.MoveToElement(element).Build().Perform();

				wait.Until(driver => driver.FindElement(poDeleteBTN).Displayed);
				driver.FindElement(poDeleteBTN).Click();

				Thread.Sleep(2000);


				wait.Until(driver => driver.FindElement(clickDBTN).Displayed);
				driver.FindElement(clickDBTN).Click();

				Thread.Sleep(2000);

				wait.Until(driver => driver.FindElement(By.CssSelector(".k-notification-wrap")).Displayed);

				IWebElement AssertInput = driver.FindElement(By.CssSelector(".k-notification-wrap"));

				string actualvalue = driver.FindElement(By.CssSelector(".k-notification-wrap")).Text;
				Assert.True(actualvalue.Contains("You have successfully deleted orders."), actualvalue + " doesn't contains");

				Thread.Sleep(3000);

				wait.Until(driver => driver.FindElement(PurchaseOrderScreenButton).Displayed);

			}
		}

		[Fact]
		public void CancelPurchaseOrder() 
		{
			using (var driver = new ChromeDriver())
			{
				var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
				Run(driver, wait);

				Guid demoGuid = Guid.NewGuid();

				wait.Until(driver => driver.FindElement(PurchaseOrderScreenButton).Displayed);
				driver.FindElement(PurchaseOrderScreenButton).Click();

				Thread.Sleep(3000);

				wait.Until(driver => driver.FindElement(createPurchaseOrderButton).Displayed);
				driver.FindElement(createPurchaseOrderButton).Click();

				Thread.Sleep(3000);

				//first step

				wait.Until(driver => driver.FindElement(clickWarehouseButton).Displayed);
				driver.FindElement(clickWarehouseButton).Click();
				Thread.Sleep(1000);


				wait.Until(driver => driver.FindElement(chooseaWarehouse).Displayed);
				driver.FindElement(chooseaWarehouse).Click();
				Thread.Sleep(1000);

				wait.Until(driver => driver.FindElement(poOrderCode).Displayed);
				driver.FindElement(poOrderCode).SendKeys("PO" + demoGuid);
				Thread.Sleep(1000);

				wait.Until(driver => driver.FindElement(orderTypeSection).Displayed);
				driver.FindElement(orderTypeSection).Click();
				Thread.Sleep(1000);

				wait.Until(driver => driver.FindElement(orderTypeArea).Displayed);
				driver.FindElement(orderTypeArea).SendKeys("OrderType" + demoGuid);
				Thread.Sleep(1000);
				wait.Until(driver => driver.FindElement(orderTypeAdd).Displayed);
				driver.FindElement(orderTypeAdd).Click();
				Thread.Sleep(1000);

				//Products step

				wait.Until(driver => driver.FindElement(addProducts).Displayed);
				driver.FindElement(addProducts).Click();
				Thread.Sleep(1000);

				wait.Until(driver => driver.FindElement(createProductButton).Displayed);
				driver.FindElement(createProductButton).Click();
				Thread.Sleep(1000);

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

				wait.Until(driver => driver.FindElement(clickAddVendorInformation).Displayed);
				driver.FindElement(clickAddVendorInformation).Click();
				Thread.Sleep(3000);

				//vendor step

				wait.Until(driver => driver.FindElement(addANewVendorButton).Displayed);
				driver.FindElement(addANewVendorButton).Click();

				wait.Until(driver => driver.FindElement(companyNickname).Displayed);
				driver.FindElement(companyNickname).SendKeys("c" + demoGuid);

				wait.Until(driver => driver.FindElement(companyName).Displayed);
				driver.FindElement(companyName).SendKeys("c" + demoGuid);

				driver.FindElement(addressName).SendKeys("ad" + demoGuid);
				driver.FindElement(addressLine1).SendKeys("ad1" + demoGuid);
				driver.FindElement(addressLine2).SendKeys("ad2" + demoGuid);
				driver.FindElement(postalCode).SendKeys("p" + demoGuid);
				driver.FindElement(city).SendKeys("ci");

				wait.Until(driver => driver.FindElement(saveVendor).Displayed);
				driver.FindElement(saveVendor).Click();

				Thread.Sleep(2000);

				wait.Until(driver => driver.FindElement(confirmPurchaseOrder).Displayed);
				driver.FindElement(confirmPurchaseOrder).Click();

				Thread.Sleep(2000);

				wait.Until(driver => driver.FindElement(confirmandPlaceOrder).Displayed);
				driver.FindElement(confirmandPlaceOrder).Click();

				Thread.Sleep(4000);

				//Cancel Part
				wait.Until(driver => driver.FindElement(PurchaseOrderScreenButton).Displayed);
				driver.FindElement(PurchaseOrderScreenButton).Click();

				Thread.Sleep(3000);

				wait.Until(driver => driver.FindElement(By.CssSelector("tr:nth-child(1) > td:nth-child(3)")).Displayed);
				Actions builder = new Actions(driver);
				IWebElement element = driver.FindElement(By.CssSelector("tr:nth-child(1) > td:nth-child(3)"));
				builder.MoveToElement(element).Build().Perform();

				driver.FindElement(By.CssSelector("tr:nth-child(1) > td:nth-child(3)")).Click();

				wait.Until(driver => driver.FindElement(poCancelBTN).Displayed);
				driver.FindElement(poCancelBTN).Click();

				Thread.Sleep(2000);

				wait.Until(driver => driver.FindElement(clickDBTN).Displayed);
				driver.FindElement(clickDBTN).Click();

				Thread.Sleep(2000);

				wait.Until(driver => driver.FindElement(By.CssSelector(".k-notification-wrap")).Displayed);

				IWebElement AssertInput = driver.FindElement(By.CssSelector(".k-notification-wrap"));

				string actualvalue = driver.FindElement(By.CssSelector(".k-notification-wrap")).Text;
				Assert.True(actualvalue.Contains("You have successfully cancelled an order."), actualvalue + " doesn't contains");

				Thread.Sleep(3000);

				wait.Until(driver => driver.FindElement(PurchaseOrderScreenButton).Displayed);

			}
		}

		[Fact]
		public void ReceiptPurchaseOrder()
		{
			using (var driver = new ChromeDriver())
			{
				var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
				Run(driver, wait);

				Guid demoGuid = Guid.NewGuid();

				wait.Until(driver => driver.FindElement(PurchaseOrderScreenButton).Displayed);
				driver.FindElement(PurchaseOrderScreenButton).Click();

				Thread.Sleep(3000);

				wait.Until(driver => driver.FindElement(createPurchaseOrderButton).Displayed);
				driver.FindElement(createPurchaseOrderButton).Click();

				Thread.Sleep(3000);

				//first step

				wait.Until(driver => driver.FindElement(clickWarehouseButton).Displayed);
				driver.FindElement(clickWarehouseButton).Click();
				Thread.Sleep(1000);


				wait.Until(driver => driver.FindElement(chooseaWarehouse).Displayed);
				driver.FindElement(chooseaWarehouse).Click();
				Thread.Sleep(1000);

				wait.Until(driver => driver.FindElement(poOrderCode).Displayed);
				driver.FindElement(poOrderCode).SendKeys("PO" + demoGuid);
				Thread.Sleep(1000);

				wait.Until(driver => driver.FindElement(orderTypeSection).Displayed);
				driver.FindElement(orderTypeSection).Click();
				Thread.Sleep(1000);

				wait.Until(driver => driver.FindElement(orderTypeArea).Displayed);
				driver.FindElement(orderTypeArea).SendKeys("OrderType" + demoGuid);
				Thread.Sleep(1000);
				wait.Until(driver => driver.FindElement(orderTypeAdd).Displayed);
				driver.FindElement(orderTypeAdd).Click();
				Thread.Sleep(1000);

				//Products step

				wait.Until(driver => driver.FindElement(addProducts).Displayed);
				driver.FindElement(addProducts).Click();
				Thread.Sleep(1000);

				wait.Until(driver => driver.FindElement(createProductButton).Displayed);
				driver.FindElement(createProductButton).Click();
				Thread.Sleep(1000);

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

				wait.Until(driver => driver.FindElement(clickAddVendorInformation).Displayed);
				driver.FindElement(clickAddVendorInformation).Click();
				Thread.Sleep(3000);

				//vendor step

				wait.Until(driver => driver.FindElement(addANewVendorButton).Displayed);
				driver.FindElement(addANewVendorButton).Click();

				wait.Until(driver => driver.FindElement(companyNickname).Displayed);
				driver.FindElement(companyNickname).SendKeys("c" + demoGuid);

				wait.Until(driver => driver.FindElement(companyName).Displayed);
				driver.FindElement(companyName).SendKeys("c" + demoGuid);

				driver.FindElement(addressName).SendKeys("ad" + demoGuid);
				driver.FindElement(addressLine1).SendKeys("ad1" + demoGuid);
				driver.FindElement(addressLine2).SendKeys("ad2" + demoGuid);
				driver.FindElement(postalCode).SendKeys("p" + demoGuid);
				driver.FindElement(city).SendKeys("ci");

				wait.Until(driver => driver.FindElement(saveVendor).Displayed);
				driver.FindElement(saveVendor).Click();

				Thread.Sleep(2000);

				wait.Until(driver => driver.FindElement(confirmPurchaseOrder).Displayed);
				driver.FindElement(confirmPurchaseOrder).Click();

				Thread.Sleep(2000);

				wait.Until(driver => driver.FindElement(confirmandPlaceOrder).Displayed);
				driver.FindElement(confirmandPlaceOrder).Click();

				Thread.Sleep(4000);

				//Receipt Part
				wait.Until(driver => driver.FindElement(PurchaseOrderScreenButton).Displayed);
				driver.FindElement(PurchaseOrderScreenButton).Click();

				Thread.Sleep(3000);

				wait.Until(driver => driver.FindElement(By.CssSelector("tr:nth-child(1) > td:nth-child(3)")).Displayed);
				Actions builder = new Actions(driver);
				IWebElement element = driver.FindElement(By.CssSelector("tr:nth-child(1) > td:nth-child(3)"));
				builder.MoveToElement(element).Build().Perform();
				driver.FindElement(By.CssSelector("tr:nth-child(1) > td:nth-child(3)")).Click();

				wait.Until(driver => driver.FindElement(poReceiptBTN).Displayed);
				driver.FindElement(poReceiptBTN).Click();

				Thread.Sleep(2000);

				wait.Until(driver => driver.FindElement(By.CssSelector(".k-notification-wrap")).Displayed);

				IWebElement AssertInput = driver.FindElement(By.CssSelector(".k-notification-wrap"));

				string actualvalue = driver.FindElement(By.CssSelector(".k-notification-wrap")).Text;
				Assert.True(actualvalue.Contains("You have successfully received orders."), actualvalue + " doesn't contains");

				Thread.Sleep(3000);

				wait.Until(driver => driver.FindElement(PurchaseOrderScreenButton).Displayed);

			}
		}

	}
}