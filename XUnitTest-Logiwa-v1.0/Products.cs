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
	public class Products : Base
	{

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
		public static By deleteProductButton = By.XPath("//button[contains(.,'Delete')]");
		public static By sureDeleteYes = By.XPath("//button[contains(.,'YES')]");
		public static By editProductButton = By.XPath("//button[contains(.,'Edit')]");

		//sometimes the system gives 500

		[Fact]
		public void CreateProductNoQuantity()
		{
			WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
			Guid demoGuid = Guid.NewGuid();

			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.UrlContains("/en/wms/dashboard"));
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((ProductsScreenButton)));
			driver.FindElement(ProductsScreenButton).Click();


			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((createProductButton)));
			driver.FindElement(createProductButton).Click();
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((sku)));
			driver.FindElement(sku).SendKeys("SKU" + demoGuid);
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((name)));
			driver.FindElement(name).SendKeys("Name" + demoGuid);
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((packType)));
			driver.FindElement(packType).Click();
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((packTypeEmptyArea)));
			driver.FindElement(packTypeEmptyArea).SendKeys("piece" + demoGuid);
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((createPackType)));
			driver.FindElement(createPackType).Click();
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((weightField)));
			driver.FindElement(weightField).FindElement(By.ClassName("k-input")).SendKeys("10");
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((initialQuantity)));
			driver.FindElement(initialQuantity).FindElement(By.ClassName("k-input")).SendKeys("");
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((addAnImage)));
			driver.FindElement(addAnImage).Click();
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((productImage)));
			driver.FindElement(productImage)
				.SendKeys("https://d163axztg8am2h.cloudfront.net/static/img/25/67/ca511d852e4dc7a82ef7011da33d.jpg");
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((productImageAddButton)));
			driver.FindElement(productImageAddButton).Click();
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((descriptionArea)));
			driver.FindElement(descriptionArea).Click();
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((EditdesriptArea)));
			driver.FindElement(EditdesriptArea).SendKeys("This is a description of the test case.");
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((addSalesPriceButton)));
			driver.FindElement(addSalesPriceButton).Click();
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((salesPriceArea)));
			driver.FindElement(salesPriceArea).FindElement(By.ClassName("k-input")).SendKeys("10");
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((addPurchaseButton)));
			driver.FindElement(addPurchaseButton).Click();
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((purchasePriceArea)));
			driver.FindElement(purchasePriceArea).FindElement(By.ClassName("k-input")).SendKeys("10");
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((addTaxRateButton)));
			driver.FindElement(addTaxRateButton).Click();
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((taxRateArea)));
			driver.FindElement(taxRateArea).FindElement(By.ClassName("k-input")).SendKeys("10");
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((addUPCButton)));
			driver.FindElement(addUPCButton).Click();
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((uPCArea)));
			driver.FindElement(uPCArea).SendKeys("UPC-1");
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((AddProductType)));
			driver.FindElement(AddProductType).Click();
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((ProductTypeArea)));
			driver.FindElement(ProductTypeArea).Click();
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((ProductTypeArea2)));
			driver.FindElement(ProductTypeArea2).SendKeys("producttype" + demoGuid);
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((clickProductType)));
			driver.FindElement(clickProductType).Click();
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((productSaveButton)));
			driver.FindElement(productSaveButton).Click();


			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector(".k-notification-content")));


			IWebElement AssertInput = driver.FindElement(By.CssSelector(".k-notification-content"));
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(AssertInput));

			string actualvalue = driver.FindElement(By.CssSelector(".k-notification-content")).Text;
			Assert.True(actualvalue.Contains("You have successfully created a new product."), actualvalue + " doesn't contains");

			Thread.Sleep(3000);
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((ProductsScreenButton)));
		}

		[Fact]
		public void DeleteProduct()
		{
			WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.UrlContains("/en/wms/dashboard"));
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((ProductsScreenButton)));
			driver.FindElement(ProductsScreenButton).Click();

			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector("tr:nth-child(1) > td:nth-child(3)")));
			Actions builder = new Actions(driver);
			IWebElement element = driver.FindElement(By.CssSelector("tr:nth-child(1) > td:nth-child(3)"));
			builder.MoveToElement(element).Build().Perform();
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((deleteProductButton)));
			driver.FindElement(deleteProductButton).Click();
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((sureDeleteYes)));
			driver.FindElement(sureDeleteYes).Click();

			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector(".k-notification-wrap")));

			IWebElement AssertInput = driver.FindElement(By.CssSelector(".k-notification-wrap"));
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(AssertInput));

			string actualvalue = driver.FindElement(By.CssSelector(".k-notification-wrap")).Text;
			Assert.True(actualvalue.Contains("Product delete operation successfully completed."), actualvalue + " doesn't contains");

			Thread.Sleep(3000);
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((ProductsScreenButton)));


		}

		[Fact]
		public void CreateProductWithInitialQuantity()
		{
			WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
			Guid demoGuid = Guid.NewGuid();

			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.UrlContains("/en/wms/dashboard"));
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((ProductsScreenButton)));
			driver.FindElement(ProductsScreenButton).Click();

			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((createProductButton)));
			driver.FindElement(createProductButton).Click();
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((sku)));
			driver.FindElement(sku).SendKeys("SKU" + demoGuid);
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((name)));
			driver.FindElement(name).SendKeys("Name" + demoGuid);
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((packType)));
			driver.FindElement(packType).Click();
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((packTypeEmptyArea)));
			driver.FindElement(packTypeEmptyArea).SendKeys("piece" + demoGuid);
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((createPackType)));
			driver.FindElement(createPackType).Click();
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((weightField)));
			driver.FindElement(weightField).FindElement(By.ClassName("k-input")).SendKeys("10");
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((initialQuantity)));
			driver.FindElement(initialQuantity).FindElement(By.ClassName("k-input")).SendKeys("10");
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((addAnImage)));
			driver.FindElement(addAnImage).Click();
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((productImage)));
			driver.FindElement(productImage)
				.SendKeys("https://d163axztg8am2h.cloudfront.net/static/img/25/67/ca511d852e4dc7a82ef7011da33d.jpg");
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((productImageAddButton)));
			driver.FindElement(productImageAddButton).Click();
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((descriptionArea)));
			driver.FindElement(descriptionArea).Click();
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((EditdesriptArea)));
			driver.FindElement(EditdesriptArea).SendKeys("This is a description of the test case.");
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((addSalesPriceButton)));
			driver.FindElement(addSalesPriceButton).Click();
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((salesPriceArea)));
			driver.FindElement(salesPriceArea).FindElement(By.ClassName("k-input")).SendKeys("10");
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((addPurchaseButton)));
			driver.FindElement(addPurchaseButton).Click();
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((purchasePriceArea)));
			driver.FindElement(purchasePriceArea).FindElement(By.ClassName("k-input")).SendKeys("10");
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((addTaxRateButton)));
			driver.FindElement(addTaxRateButton).Click();
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((taxRateArea)));
			driver.FindElement(taxRateArea).FindElement(By.ClassName("k-input")).SendKeys("10");
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((addUPCButton)));
			driver.FindElement(addUPCButton).Click();
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((uPCArea)));
			driver.FindElement(uPCArea).SendKeys("UPC-1");
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((AddProductType)));
			driver.FindElement(AddProductType).Click();
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((ProductTypeArea)));
			driver.FindElement(ProductTypeArea).Click();
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((ProductTypeArea2)));
			driver.FindElement(ProductTypeArea2).SendKeys("producttype" + demoGuid);
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((clickProductType)));
			driver.FindElement(clickProductType).Click();
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((productSaveButton)));
			driver.FindElement(productSaveButton).Click();


			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector(".k-notification-content")));


			IWebElement AssertInput = driver.FindElement(By.CssSelector(".k-notification-content"));
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(AssertInput));

			string actualvalue = driver.FindElement(By.CssSelector(".k-notification-content")).Text;
			Assert.True(actualvalue.Contains("You have successfully created a new product."), actualvalue + " doesn't contains");

			Thread.Sleep(3000);
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((ProductsScreenButton)));

		}

		[Fact]
		public void EditProduct()
		{
			WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
			Guid demoGuid = Guid.NewGuid();

			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.UrlContains("/en/wms/dashboard"));
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((ProductsScreenButton)));
			driver.FindElement(ProductsScreenButton).Click();

			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector("tr:nth-child(1) > td:nth-child(3)")));
			Actions builder = new Actions(driver);
			IWebElement element = driver.FindElement(By.CssSelector("tr:nth-child(1) > td:nth-child(3)"));
			builder.MoveToElement(element).Build().Perform();
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((deleteProductButton)));
			driver.FindElement(editProductButton).Click();
			//driver.FindElement(sku).SendKeys(Keys.Chord(Keys.CONTROL, "a", Keys.DELETE));
			driver.FindElement(sku).SendKeys("EDSKU" + demoGuid);
			driver.FindElement(productSaveButton).Click();

			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector(".k-notification-content")));


			IWebElement AssertInput = driver.FindElement(By.CssSelector(".k-notification-content"));
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(AssertInput));

			string actualvalue = driver.FindElement(By.CssSelector(".k-notification-content")).Text;
			Assert.True(actualvalue.Contains("You have successfully created a new product."), actualvalue + " doesn't contains");

			Thread.Sleep(3000);
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((ProductsScreenButton)));


		}

		[Fact]
		public void DeleteProduct2()
		{
			DeleteProduct();
		}

	}
}