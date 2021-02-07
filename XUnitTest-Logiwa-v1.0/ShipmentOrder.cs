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
using ExpectedConditions = OpenQA.Selenium.Support.UI.ExpectedConditions;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Remote;

namespace XUnitTest_Logiwa_v1._0
{
	public class ShipmentOrder : Base
	{
		public static By MainSalesButton = By.Id("navbarDropdownSales");
		public static By ShipmentScreenButton = By.XPath("//a[contains(text(),'Shipment Order')]");
		public static By createShipmentOrderButton = By.XPath("//span[contains(.,'Create Shipment Order')]");
		public static By searchProductBar = By.XPath(
				"//kendo-multiselect[@id='productOptions']//kendo-searchbar[@class='k-searchbar']/input[@role='listbox']");
		public static By firstProductForSo = By.XPath(
				"//platform-root/kendo-popup[@class='k-animation-container k-animation-container-shown']//kendo-list[@class='ng-star-inserted']//ul[@role='listbox']/li[@role='option']");
		public static By clickAddButton1 = By.XPath("//button[contains(.,'Add')]");
		public static By clickProceedtoCustomer = By.XPath("//button[contains(.,'Add Shipping Information')]");
		public static By sOAddressLine1 = By.Name("addressLine1");
		public static By sOAddressLine2 = By.Name("addressLine2");
		public static By sOPostalCode = By.Name("postalCode");
		public static By sOCity = By.Name("city");
		public static By sOCustomerFNBTN = By.CssSelector("#customerFirstNameCollapseButton > span");
		public static By sOCustomerFN = By.Name("customerFirstName");
		public static By sOCustomerLNBTN = By.CssSelector("#customerLastNameCollapseButton > span");
		public static By sOCustomerLN = By.Name("customerLastName");
		public static By sOCustomerMBTN = By.CssSelector("#customerEmailCollapseButton > span");
		public static By sOCustomerM = By.Name("customerEmail");
		public static By sOCustomerPhone = By.CssSelector("#shipmentPhoneNumberCollapseButton > span");
		public static By sOCustomerPhoneArea = By.Name("shipmentPhoneNumber");
		public static By clickOrderDetails = By.XPath("//button[contains(.,'Add Order Details')]");
		public static By soOrderCode = By.Name("code");
		public static By orderTypeSection = By
				.XPath("//kendo-dropdownlist[@id='shipmentOrderTypeName']//span[@class='k-input']");
		public static By orderTypeArea = By.CssSelector(".k-list-filter [tabindex]");
		public static By orderTypeAdd = By.XPath("//button[contains(.,'Create New Shipment Order Type')]");
		public static By proceedToApprove = By.XPath("//button[contains(.,'Confirm Shipment Order')]");
		public static By approveAndPlaceOrder = By.XPath("//button[contains(.,'Confirm and Place Order')]");
		public static By firstShipmentOrder = By.CssSelector("tr:nth-child(1) > td:nth-child(3)");
		public static By editShipmentOrder = By.XPath("//span[contains(.,'Edit')]");
		public static By editSearchProduct = By.CssSelector(".k-searchbar .k-input");
		public static By firstProductForSoforEdit = By.XPath("//kendo-list/div/ul/li");
		public static By sOEditAdd = By.XPath("//button[contains(.,'Add')]");
		public static By sOfirstQuantityDelete = By.XPath(
				"//div[@id='collapseOne']/div/platform-shipment-order-product-form-view/div[2]/div/platform-grid/kendo-grid/div/table/tbody/tr/td[5]/div/kendo-numerictextbox/span/input");
		public static By sOShowDetails = By.CssSelector("#headingTwo .btn");
		public static By sOEditSaveAndApplyChangesElement = By.XPath("//button[contains(.,'Save and Apply Changes')]");
		public static By deleteShipmentOrder = By.XPath("//div[3]/div/div[2]/platform-button[2]/button/span");
		public static By clickDBTN = By.XPath("//button[contains(.,'YES')]");
		public static By shipShipmentOrder = By.XPath("//button[contains(.,'Ship Order')]");

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
		public static By showDetails2 = By.XPath("//div[@id='headingThree']/div/div[2]/button");
		public static By saveApplyChanges = By.XPath("//div[2]/div[2]/button");
		public static By clickWarehouseButton = By
				.XPath("//dynamic-platform-form-control[3]/div/dynamic-platform-dropdownlist/kendo-dropdownlist/span/span");
		public static By chooseaWarehouse = By.XPath("//li[contains(.,'Default Warehouse')]");
		public static By addProducts = By.XPath("//button[contains(.,'Add Products')]");
		public static By sureDeleteYes = By.XPath("//button[contains(.,'YES')]");


		[Fact]
     
        public void CreateShipmentOrder()
		{
			using (var driver = new ChromeDriver())
			{
				var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
				Run(driver, wait);
		

				Guid demoGuid = Guid.NewGuid();

				//wait.Until(driver => driver.FindElement(MainSalesButton).Displayed);
				wait.Until(ExpectedConditions.ElementToBeClickable(MainSalesButton));
				driver.FindElement(MainSalesButton).Click();
				wait.Until(driver => driver.FindElement(ShipmentScreenButton).Displayed);
				driver.FindElement(ShipmentScreenButton).Click();

				Thread.Sleep(3000);

				wait.Until(driver => driver.FindElement(createShipmentOrderButton).Displayed);
				driver.FindElement(createShipmentOrderButton).Click();

				Thread.Sleep(3000);


				//first step

				/*
				wait.Until(ExpectedConditions.ElementToBeClickable(clickWarehouseButton));
				driver.FindElement(clickWarehouseButton).Click();
				Thread.Sleep(1000);


				wait.Until(driver => driver.FindElement(chooseaWarehouse).Displayed);
				driver.FindElement(chooseaWarehouse).Click();
				Thread.Sleep(1000);
				*/

				wait.Until(driver => driver.FindElement(soOrderCode).Displayed);
				driver.FindElement(soOrderCode).SendKeys("SO" + demoGuid);
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

				wait.Until(ExpectedConditions.ElementToBeClickable(sku));

				//wait.Until(driver => driver.FindElement(sku).Displayed);
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

				wait.Until(driver => driver.FindElement(clickProceedtoCustomer).Displayed);
				driver.FindElement(clickProceedtoCustomer).Click();
				Thread.Sleep(3000);

				//customer step

				wait.Until(ExpectedConditions.ElementToBeClickable(sOAddressLine1));
				driver.FindElement(sOAddressLine1).SendKeys("224 Wallace Ave #200");

				wait.Until(ExpectedConditions.ElementToBeClickable(sOAddressLine2));
				driver.FindElement(sOAddressLine2).SendKeys("Redwood City, ON M6H 1V7, California");

				wait.Until(ExpectedConditions.ElementToBeClickable(sOPostalCode));
				driver.FindElement(sOPostalCode).SendKeys("90017");


				wait.Until(ExpectedConditions.ElementToBeClickable(sOCity));
				driver.FindElement(sOCity).SendKeys("California");

				Thread.Sleep(2000);


				//IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
				//js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight);");
				//((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", sOCustomerFNBTN);
				//driver.ExecuteJavaScript("arguments[0].scrollIntoView({block: \"center\", inline: \"center\"});", sOCustomerFNBTN);
				//JavaScriptExecutor.ExecuteScript("window.scrollBy(0,2000)", "");
				//driver.FindElement(sOCity).Click();
				//Actions actions = new Actions(driver);
				//actions.SendKeys(OpenQA.Selenium.Keys.End).Build().Perform();

				/*
						wait.Until(ExpectedConditions.ElementToBeClickable(sOCustomerFNBTN));
						driver.FindElement(sOCustomerFNBTN).Click();
						wait.Until(ExpectedConditions.ElementToBeClickable(sOCustomerFN));
						driver.FindElement(sOCustomerFN).SendKeys("Batu");
						wait.Until(ExpectedConditions.ElementToBeClickable(sOCustomerLNBTN));
						driver.FindElement(sOCustomerLNBTN).Click();
						wait.Until(ExpectedConditions.ElementToBeClickable(sOCustomerLN));
						driver.FindElement(sOCustomerLN).SendKeys("Caglasin");
						wait.Until(ExpectedConditions.ElementToBeClickable(sOCustomerMBTN));
						driver.FindElement(sOCustomerMBTN).Click();
						wait.Until(ExpectedConditions.ElementToBeClickable(sOCustomerM));
						driver.FindElement(sOCustomerM).SendKeys("baturaycaglasintest@gmail.com");

						wait.Until(ExpectedConditions.ElementToBeClickable(sOCustomerPhone));
						driver.FindElement(sOCustomerPhone).Click();
						wait.Until(ExpectedConditions.ElementToBeClickable(sOCustomerPhoneArea));
						driver.FindElement(sOCustomerPhoneArea).SendKeys("02122222222");

						*/
				wait.Until(ExpectedConditions.ElementToBeClickable(proceedToApprove));
				driver.FindElement(proceedToApprove).Click();


				wait.Until(ExpectedConditions.ElementToBeClickable(approveAndPlaceOrder));
				driver.FindElement(approveAndPlaceOrder).Click();


				Thread.Sleep(2000);
				wait.Until(driver => driver.FindElement(ShipmentScreenButton).Displayed);


			}
		}




		[Fact]

		public void EditShipmentOrder()
		{
			using (var driver = new ChromeDriver())
			{
				var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
				Run(driver, wait);


				Guid demoGuid = Guid.NewGuid();

				//wait.Until(driver => driver.FindElement(MainSalesButton).Displayed);
				wait.Until(ExpectedConditions.ElementToBeClickable(MainSalesButton));
				driver.FindElement(MainSalesButton).Click();
				wait.Until(driver => driver.FindElement(ShipmentScreenButton).Displayed);
				driver.FindElement(ShipmentScreenButton).Click();

				Thread.Sleep(3000);

				wait.Until(driver => driver.FindElement(createShipmentOrderButton).Displayed);
				driver.FindElement(createShipmentOrderButton).Click();

				Thread.Sleep(3000);


				wait.Until(driver => driver.FindElement(soOrderCode).Displayed);
				driver.FindElement(soOrderCode).SendKeys("SO" + demoGuid);
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

				wait.Until(ExpectedConditions.ElementToBeClickable(sku));

				//wait.Until(driver => driver.FindElement(sku).Displayed);
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

				wait.Until(driver => driver.FindElement(clickProceedtoCustomer).Displayed);
				driver.FindElement(clickProceedtoCustomer).Click();
				Thread.Sleep(3000);

				//customer step

				wait.Until(ExpectedConditions.ElementToBeClickable(sOAddressLine1));
				driver.FindElement(sOAddressLine1).SendKeys("224 Wallace Ave #200");

				wait.Until(ExpectedConditions.ElementToBeClickable(sOAddressLine2));
				driver.FindElement(sOAddressLine2).SendKeys("Redwood City, ON M6H 1V7, California");

				wait.Until(ExpectedConditions.ElementToBeClickable(sOPostalCode));
				driver.FindElement(sOPostalCode).SendKeys("90017");


				wait.Until(ExpectedConditions.ElementToBeClickable(sOCity));
				driver.FindElement(sOCity).SendKeys("California");

				Thread.Sleep(2000);


				wait.Until(ExpectedConditions.ElementToBeClickable(proceedToApprove));
				driver.FindElement(proceedToApprove).Click();


				wait.Until(ExpectedConditions.ElementToBeClickable(approveAndPlaceOrder));
				driver.FindElement(approveAndPlaceOrder).Click();


				Thread.Sleep(2000);

				wait.Until(ExpectedConditions.ElementToBeClickable(MainSalesButton));
				driver.FindElement(MainSalesButton).Click();
				wait.Until(driver => driver.FindElement(ShipmentScreenButton).Displayed);
				driver.FindElement(ShipmentScreenButton).Click();

				Thread.Sleep(3000);


				wait.Until(ExpectedConditions.ElementToBeClickable((firstShipmentOrder)));
				driver.FindElement(firstShipmentOrder).Click();
				Thread.Sleep(2000);
				wait.Until(ExpectedConditions.ElementToBeClickable((editShipmentOrder)));
				driver.FindElement(editShipmentOrder).Click();
				Thread.Sleep(2000);
				wait.Until(ExpectedConditions.ElementToBeClickable((editSearchProduct)));
				driver.FindElement(editSearchProduct).SendKeys("sku");
				Thread.Sleep(2000);
				driver.FindElement(firstProductForSoforEdit).Click();
				Thread.Sleep(2000);
				wait.Until(ExpectedConditions.ElementToBeClickable((sOEditAdd)));
				driver.FindElement(sOEditAdd).Click();
				driver.FindElement(sOfirstQuantityDelete).Clear();
				driver.FindElement(sOfirstQuantityDelete).SendKeys("5");
				Thread.Sleep(2000);
				wait.Until(ExpectedConditions.ElementToBeClickable((sOEditSaveAndApplyChangesElement)));
				driver.FindElement(sOEditSaveAndApplyChangesElement).Click();
				Thread.Sleep(5000);

				wait.Until(driver => driver.FindElement(By.CssSelector(".k-notification-wrap")).Displayed);

				IWebElement AssertInput = driver.FindElement(By.CssSelector(".k-notification-wrap"));

				string actualvalue = driver.FindElement(By.CssSelector(".k-notification-wrap")).Text;
				Assert.True(actualvalue.Contains("You have successfully edited a shipment order."), actualvalue + " doesn't contains");

				Thread.Sleep(3000);

				wait.Until(driver => driver.FindElement(MainSalesButton).Displayed);


			}
		}

		[Fact]

		public void DeleteShipmentOrder()
		{
			using (var driver = new ChromeDriver())
			{
				var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
				Run(driver, wait);


				Guid demoGuid = Guid.NewGuid();

				//wait.Until(driver => driver.FindElement(MainSalesButton).Displayed);
				wait.Until(ExpectedConditions.ElementToBeClickable(MainSalesButton));
				driver.FindElement(MainSalesButton).Click();
				wait.Until(driver => driver.FindElement(ShipmentScreenButton).Displayed);
				driver.FindElement(ShipmentScreenButton).Click();

				Thread.Sleep(3000);

				wait.Until(driver => driver.FindElement(createShipmentOrderButton).Displayed);
				driver.FindElement(createShipmentOrderButton).Click();

				Thread.Sleep(3000);


				wait.Until(driver => driver.FindElement(soOrderCode).Displayed);
				driver.FindElement(soOrderCode).SendKeys("SO" + demoGuid);
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

				wait.Until(ExpectedConditions.ElementToBeClickable(sku));

				//wait.Until(driver => driver.FindElement(sku).Displayed);
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

				wait.Until(driver => driver.FindElement(clickProceedtoCustomer).Displayed);
				driver.FindElement(clickProceedtoCustomer).Click();
				Thread.Sleep(3000);

				//customer step

				wait.Until(ExpectedConditions.ElementToBeClickable(sOAddressLine1));
				driver.FindElement(sOAddressLine1).SendKeys("224 Wallace Ave #200");

				wait.Until(ExpectedConditions.ElementToBeClickable(sOAddressLine2));
				driver.FindElement(sOAddressLine2).SendKeys("Redwood City, ON M6H 1V7, California");

				wait.Until(ExpectedConditions.ElementToBeClickable(sOPostalCode));
				driver.FindElement(sOPostalCode).SendKeys("90017");


				wait.Until(ExpectedConditions.ElementToBeClickable(sOCity));
				driver.FindElement(sOCity).SendKeys("California");

				Thread.Sleep(2000);


				wait.Until(ExpectedConditions.ElementToBeClickable(proceedToApprove));
				driver.FindElement(proceedToApprove).Click();


				wait.Until(ExpectedConditions.ElementToBeClickable(approveAndPlaceOrder));
				driver.FindElement(approveAndPlaceOrder).Click();


				Thread.Sleep(2000);

				wait.Until(ExpectedConditions.ElementToBeClickable(MainSalesButton));
				driver.FindElement(MainSalesButton).Click();
				wait.Until(driver => driver.FindElement(ShipmentScreenButton).Displayed);
				driver.FindElement(ShipmentScreenButton).Click();

				Thread.Sleep(3000);

				wait.Until(ExpectedConditions.ElementToBeClickable((firstShipmentOrder)));
				driver.FindElement(firstShipmentOrder).Click();
				Thread.Sleep(2000);

				//delete part

				wait.Until(ExpectedConditions.ElementToBeClickable((deleteShipmentOrder)));
				driver.FindElement(deleteShipmentOrder).Click();
				Thread.Sleep(2000);


				wait.Until(driver => driver.FindElement(clickDBTN).Displayed);
				driver.FindElement(clickDBTN).Click();

				Thread.Sleep(2000);


				wait.Until(driver => driver.FindElement(By.CssSelector(".k-notification-wrap")).Displayed);

				IWebElement AssertInput = driver.FindElement(By.CssSelector(".k-notification-wrap"));

				string actualvalue = driver.FindElement(By.CssSelector(".k-notification-wrap")).Text;
				Assert.True(actualvalue.Contains("You have successfully deleted orders."), actualvalue + " doesn't contains");

				Thread.Sleep(3000);

				wait.Until(driver => driver.FindElement(MainSalesButton).Displayed);



			}
		}


		[Fact]

		public void ShipShipmentOrder()
		{
			using (var driver = new ChromeDriver())
			{
				var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
				Run(driver, wait);


				Guid demoGuid = Guid.NewGuid();

				//wait.Until(driver => driver.FindElement(MainSalesButton).Displayed);
				wait.Until(ExpectedConditions.ElementToBeClickable(MainSalesButton));
				driver.FindElement(MainSalesButton).Click();
				wait.Until(driver => driver.FindElement(ShipmentScreenButton).Displayed);
				driver.FindElement(ShipmentScreenButton).Click();

				Thread.Sleep(3000);

				wait.Until(driver => driver.FindElement(createShipmentOrderButton).Displayed);
				driver.FindElement(createShipmentOrderButton).Click();

				Thread.Sleep(3000);


				wait.Until(driver => driver.FindElement(soOrderCode).Displayed);
				driver.FindElement(soOrderCode).SendKeys("SO" + demoGuid);
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

				wait.Until(ExpectedConditions.ElementToBeClickable(sku));

				//wait.Until(driver => driver.FindElement(sku).Displayed);
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

				wait.Until(driver => driver.FindElement(clickProceedtoCustomer).Displayed);
				driver.FindElement(clickProceedtoCustomer).Click();
				Thread.Sleep(3000);

				//customer step

				wait.Until(ExpectedConditions.ElementToBeClickable(sOAddressLine1));
				driver.FindElement(sOAddressLine1).SendKeys("224 Wallace Ave #200");

				wait.Until(ExpectedConditions.ElementToBeClickable(sOAddressLine2));
				driver.FindElement(sOAddressLine2).SendKeys("Redwood City, ON M6H 1V7, California");

				wait.Until(ExpectedConditions.ElementToBeClickable(sOPostalCode));
				driver.FindElement(sOPostalCode).SendKeys("90017");


				wait.Until(ExpectedConditions.ElementToBeClickable(sOCity));
				driver.FindElement(sOCity).SendKeys("California");

				Thread.Sleep(2000);


				wait.Until(ExpectedConditions.ElementToBeClickable(proceedToApprove));
				driver.FindElement(proceedToApprove).Click();


				wait.Until(ExpectedConditions.ElementToBeClickable(approveAndPlaceOrder));
				driver.FindElement(approveAndPlaceOrder).Click();


				Thread.Sleep(2000);

				wait.Until(ExpectedConditions.ElementToBeClickable(MainSalesButton));
				driver.FindElement(MainSalesButton).Click();
				wait.Until(driver => driver.FindElement(ShipmentScreenButton).Displayed);
				driver.FindElement(ShipmentScreenButton).Click();

				Thread.Sleep(3000);

				wait.Until(ExpectedConditions.ElementToBeClickable((firstShipmentOrder)));
				driver.FindElement(firstShipmentOrder).Click();
				Thread.Sleep(2000);

				//ship part

				wait.Until(ExpectedConditions.ElementToBeClickable((shipShipmentOrder)));
				driver.FindElement(shipShipmentOrder).Click();
				Thread.Sleep(2000);

				wait.Until(driver => driver.FindElement(By.CssSelector(".k-notification-wrap")).Displayed);

				IWebElement AssertInput = driver.FindElement(By.CssSelector(".k-notification-wrap"));

				string actualvalue = driver.FindElement(By.CssSelector(".k-notification-wrap")).Text;
				Assert.True(actualvalue.Contains("You have successfully shipped an order."), actualvalue + " doesn't contains");

				Thread.Sleep(3000);

				wait.Until(driver => driver.FindElement(MainSalesButton).Displayed);



			}
		}

	}

	}
