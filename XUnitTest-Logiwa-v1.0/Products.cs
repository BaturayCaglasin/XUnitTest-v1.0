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
	public class Products : Base
	{

		public static By MainInventoryScreenButton = By.Id("navbarDropdownInventory");
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
		public void CreateProductWithoutQuantity()
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

				wait.Until(driver => driver.FindElement(weightField).Displayed);
				driver.FindElement(weightField).FindElement(By.ClassName("k-input")).SendKeys("10");

				wait.Until(driver => driver.FindElement(initialQuantity).Displayed);
				driver.FindElement(initialQuantity).FindElement(By.ClassName("k-input")).SendKeys("0");

				wait.Until(driver => driver.FindElement(addAnImage).Displayed);
				driver.FindElement(addAnImage).Click();

				wait.Until(driver => driver.FindElement(productImage).Displayed);
				driver.FindElement(productImage)
					.SendKeys("https://d163axztg8am2h.cloudfront.net/static/img/25/67/ca511d852e4dc7a82ef7011da33d.jpg");

				wait.Until(driver => driver.FindElement(productImageAddButton).Displayed);
				driver.FindElement(productImageAddButton).Click();

				wait.Until(driver => driver.FindElement(descriptionArea).Displayed);
				driver.FindElement(descriptionArea).Click();

				wait.Until(driver => driver.FindElement(EditdesriptArea).Displayed);
				driver.FindElement(EditdesriptArea).SendKeys("This is a description of the test case.");

				wait.Until(driver => driver.FindElement(addSalesPriceButton).Displayed);
				driver.FindElement(addSalesPriceButton).Click();

				wait.Until(driver => driver.FindElement(salesPriceArea).Displayed);
				driver.FindElement(salesPriceArea).FindElement(By.ClassName("k-input")).SendKeys("10");

				wait.Until(driver => driver.FindElement(addPurchaseButton).Displayed);
				driver.FindElement(addPurchaseButton).Click();

				wait.Until(driver => driver.FindElement(purchasePriceArea).Displayed);
				driver.FindElement(purchasePriceArea).FindElement(By.ClassName("k-input")).SendKeys("10");

				wait.Until(driver => driver.FindElement(addTaxRateButton).Displayed);
				driver.FindElement(addTaxRateButton).Click();

				wait.Until(driver => driver.FindElement(taxRateArea).Displayed);
				driver.FindElement(taxRateArea).FindElement(By.ClassName("k-input")).SendKeys("10");

				wait.Until(driver => driver.FindElement(addUPCButton).Displayed);
				driver.FindElement(addUPCButton).Click();

				wait.Until(driver => driver.FindElement(uPCArea).Displayed);
				driver.FindElement(uPCArea).SendKeys("UPC-1");

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

				wait.Until(driver => driver.FindElement(By.CssSelector(".k-notification-wrap")).Displayed);
				IWebElement AssertInput = driver.FindElement(By.CssSelector(".k-notification-wrap"));

				string actualvalue = driver.FindElement(By.CssSelector(".k-notification-wrap")).Text;
				Assert.True(actualvalue.Contains("You have successfully created a new product."), actualvalue + " doesn't contains");

				Thread.Sleep(3000);
				wait.Until(driver => driver.FindElement(MainInventoryScreenButton).Displayed);
			}
		}
		   
		[Fact]
		public void DeleteProduct()
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
		
				wait.Until(driver => driver.FindElement(By.CssSelector("tr:nth-child(1) > td:nth-child(3)")).Displayed);
				Actions builder = new Actions(driver);
				IWebElement element = driver.FindElement(By.CssSelector("tr:nth-child(1) > td:nth-child(3)"));
				builder.MoveToElement(element).Build().Perform();

				wait.Until(driver => driver.FindElement(deleteProductButton).Displayed);
				driver.FindElement(deleteProductButton).Click();

				wait.Until(driver => driver.FindElement(sureDeleteYes).Displayed);
				driver.FindElement(sureDeleteYes).Click();
				Thread.Sleep(2000);

				wait.Until(driver => driver.FindElement(By.CssSelector(".k-notification-content")).Displayed);
				IWebElement AssertInput = driver.FindElement(By.CssSelector(".k-notification-content"));

				string actualvalue = driver.FindElement(By.CssSelector(".k-notification-content")).Text;
				Assert.True(actualvalue.Contains("Product delete operation successfully completed."), actualvalue + " doesn't contains");

				Thread.Sleep(3000);
				wait.Until(driver => driver.FindElement(MainInventoryScreenButton).Displayed);

			}
		}

		[Fact]
		public void CreateProductWithInitialQuantity()
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

				wait.Until(driver => driver.FindElement(weightField).Displayed);
				driver.FindElement(weightField).FindElement(By.ClassName("k-input")).SendKeys("10");

				wait.Until(driver => driver.FindElement(initialQuantity).Displayed);
				driver.FindElement(initialQuantity).FindElement(By.ClassName("k-input")).SendKeys("10");

				wait.Until(driver => driver.FindElement(addAnImage).Displayed);
				driver.FindElement(addAnImage).Click();

				wait.Until(driver => driver.FindElement(productImage).Displayed);
				driver.FindElement(productImage)
					.SendKeys("https://d163axztg8am2h.cloudfront.net/static/img/25/67/ca511d852e4dc7a82ef7011da33d.jpg");

				wait.Until(driver => driver.FindElement(productImageAddButton).Displayed);
				driver.FindElement(productImageAddButton).Click();

				wait.Until(driver => driver.FindElement(descriptionArea).Displayed);
				driver.FindElement(descriptionArea).Click();

				wait.Until(driver => driver.FindElement(EditdesriptArea).Displayed);
				driver.FindElement(EditdesriptArea).SendKeys("This is a description of the test case.");

				wait.Until(driver => driver.FindElement(addSalesPriceButton).Displayed);
				driver.FindElement(addSalesPriceButton).Click();

				wait.Until(driver => driver.FindElement(salesPriceArea).Displayed);
				driver.FindElement(salesPriceArea).FindElement(By.ClassName("k-input")).SendKeys("10");

				wait.Until(driver => driver.FindElement(addPurchaseButton).Displayed);
				driver.FindElement(addPurchaseButton).Click();

				wait.Until(driver => driver.FindElement(purchasePriceArea).Displayed);
				driver.FindElement(purchasePriceArea).FindElement(By.ClassName("k-input")).SendKeys("10");

				wait.Until(driver => driver.FindElement(addTaxRateButton).Displayed);
				driver.FindElement(addTaxRateButton).Click();

				wait.Until(driver => driver.FindElement(taxRateArea).Displayed);
				driver.FindElement(taxRateArea).FindElement(By.ClassName("k-input")).SendKeys("10");

				wait.Until(driver => driver.FindElement(addUPCButton).Displayed);
				driver.FindElement(addUPCButton).Click();

				wait.Until(driver => driver.FindElement(uPCArea).Displayed);
				driver.FindElement(uPCArea).SendKeys("UPC-1");

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

				wait.Until(driver => driver.FindElement(By.CssSelector(".k-notification-wrap")).Displayed);
				IWebElement AssertInput = driver.FindElement(By.CssSelector(".k-notification-wrap"));

				string actualvalue = driver.FindElement(By.CssSelector(".k-notification-wrap")).Text;
				Assert.True(actualvalue.Contains("You have successfully created a new product."), actualvalue + " doesn't contains");

				Thread.Sleep(3000);
				wait.Until(driver => driver.FindElement(MainInventoryScreenButton).Displayed);
			}
		}

		[Fact]
		public void EditProduct()
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


				wait.Until(driver => driver.FindElement(By.CssSelector("tr:nth-child(1) > td:nth-child(3)")).Displayed);
				Actions builder = new Actions(driver);
				IWebElement element = driver.FindElement(By.CssSelector("tr:nth-child(1) > td:nth-child(3)"));
				builder.MoveToElement(element).Build().Perform();

				wait.Until(driver => driver.FindElement(editProductButton).Displayed);
				driver.FindElement(editProductButton).Click();
				Thread.Sleep(2000);
				wait.Until(driver => driver.FindElement(sku).Displayed);
				//driver.FindElement(sku).SendKeys(Keys.Chord(Keys.CONTROL, "a", Keys.DELETE));
				driver.FindElement(sku).SendKeys("EDSKU" + demoGuid);
				driver.FindElement(productSaveButton).Click();

				wait.Until(driver => driver.FindElement(By.CssSelector(".k-notification-content")).Displayed);
				wait.Until(driver => driver.FindElement(By.CssSelector(".k-notification-wrap")).Displayed);
				IWebElement AssertInput = driver.FindElement(By.CssSelector(".k-notification-wrap"));

				string actualvalue = driver.FindElement(By.CssSelector(".k-notification-wrap")).Text;
				Assert.True(actualvalue.Contains("You have successfully created a new product."), actualvalue + " doesn't contains");

				Thread.Sleep(3000);
				wait.Until(driver => driver.FindElement(MainInventoryScreenButton).Displayed);
			}

		}

	}
}