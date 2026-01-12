using DataEntities;

namespace TinyShop.Tests;

[TestClass]
public class ProductTests
{
    [TestMethod]
    public void Product_NewInstance_HasDefaultValues()
    {
        // Arrange & Act
        var product = new Product();

        // Assert
        Assert.AreEqual(0, product.Id);
        Assert.IsNull(product.Name);
        Assert.IsNull(product.Description);
        Assert.AreEqual(0m, product.Price);
        Assert.IsNull(product.ImageUrl);
    }

    #region Id Property Tests

    [TestMethod]
    public void Id_SetValue_ReturnsSetValue()
    {
        // Arrange
        var product = new Product();
        var expectedId = 42;

        // Act
        product.Id = expectedId;

        // Assert
        Assert.AreEqual(expectedId, product.Id);
    }

    [TestMethod]
    [DataRow(1)]
    [DataRow(100)]
    [DataRow(999999)]
    [DataRow(0)]
    [DataRow(-1)]
    public void Id_SetVariousValues_ReturnsSetValue(int id)
    {
        // Arrange
        var product = new Product();

        // Act
        product.Id = id;

        // Assert
        Assert.AreEqual(id, product.Id);
    }

    #endregion

    #region Name Property Tests

    [TestMethod]
    public void Name_SetValue_ReturnsSetValue()
    {
        // Arrange
        var product = new Product();
        var expectedName = "Test Product";

        // Act
        product.Name = expectedName;

        // Assert
        Assert.AreEqual(expectedName, product.Name);
    }

    [TestMethod]
    [DataRow("Laptop")]
    [DataRow("Gaming Mouse")]
    [DataRow("Wireless Keyboard")]
    [DataRow("")]
    [DataRow(null)]
    public void Name_SetVariousValues_ReturnsSetValue(string? name)
    {
        // Arrange
        var product = new Product();

        // Act
        product.Name = name;

        // Assert
        Assert.AreEqual(name, product.Name);
    }

    [TestMethod]
    public void Name_SetEmptyString_ReturnsEmptyString()
    {
        // Arrange
        var product = new Product();

        // Act
        product.Name = string.Empty;

        // Assert
        Assert.AreEqual(string.Empty, product.Name);
    }

    [TestMethod]
    public void Name_SetNull_ReturnsNull()
    {
        // Arrange
        var product = new Product();

        // Act
        product.Name = null;

        // Assert
        Assert.IsNull(product.Name);
    }

    #endregion

    #region Description Property Tests

    [TestMethod]
    public void Description_SetValue_ReturnsSetValue()
    {
        // Arrange
        var product = new Product();
        var expectedDescription = "This is a test description";

        // Act
        product.Description = expectedDescription;

        // Assert
        Assert.AreEqual(expectedDescription, product.Description);
    }

    [TestMethod]
    [DataRow("High-performance laptop with 16GB RAM")]
    [DataRow("Ergonomic gaming mouse with RGB lighting")]
    [DataRow("Compact wireless keyboard")]
    [DataRow("")]
    [DataRow(null)]
    public void Description_SetVariousValues_ReturnsSetValue(string? description)
    {
        // Arrange
        var product = new Product();

        // Act
        product.Description = description;

        // Assert
        Assert.AreEqual(description, product.Description);
    }

    [TestMethod]
    public void Description_SetEmptyString_ReturnsEmptyString()
    {
        // Arrange
        var product = new Product();

        // Act
        product.Description = string.Empty;

        // Assert
        Assert.AreEqual(string.Empty, product.Description);
    }

    [TestMethod]
    public void Description_SetNull_ReturnsNull()
    {
        // Arrange
        var product = new Product();

        // Act
        product.Description = null;

        // Assert
        Assert.IsNull(product.Description);
    }

    #endregion

    #region Price Property Tests

    [TestMethod]
    public void Price_SetValue_ReturnsSetValue()
    {
        // Arrange
        var product = new Product();
        var expectedPrice = 99.99m;

        // Act
        product.Price = expectedPrice;

        // Assert
        Assert.AreEqual(expectedPrice, product.Price);
    }

    [TestMethod]
    [DataRow(0.00)]
    [DataRow(1.99)]
    [DataRow(99.99)]
    [DataRow(999.99)]
    [DataRow(9999.99)]
    public void Price_SetVariousPositiveValues_ReturnsSetValue(double priceValue)
    {
        // Arrange
        var product = new Product();
        var price = (decimal)priceValue;

        // Act
        product.Price = price;

        // Assert
        Assert.AreEqual(price, product.Price);
    }

    [TestMethod]
    public void Price_SetZero_ReturnsZero()
    {
        // Arrange
        var product = new Product();

        // Act
        product.Price = 0m;

        // Assert
        Assert.AreEqual(0m, product.Price);
    }

    [TestMethod]
    [DataRow(-1.00)]
    [DataRow(-99.99)]
    [DataRow(-999.99)]
    public void Price_SetNegativeValue_ReturnsNegativeValue(double priceValue)
    {
        // Arrange
        var product = new Product();
        var price = (decimal)priceValue;

        // Act
        product.Price = price;

        // Assert
        Assert.AreEqual(price, product.Price);
    }

    [TestMethod]
    public void Price_SetLargeValue_ReturnsLargeValue()
    {
        // Arrange
        var product = new Product();
        var expectedPrice = 999999.99m;

        // Act
        product.Price = expectedPrice;

        // Assert
        Assert.AreEqual(expectedPrice, product.Price);
    }

    #endregion

    #region ImageUrl Property Tests

    [TestMethod]
    public void ImageUrl_SetValue_ReturnsSetValue()
    {
        // Arrange
        var product = new Product();
        var expectedImageUrl = "https://example.com/image.jpg";

        // Act
        product.ImageUrl = expectedImageUrl;

        // Assert
        Assert.AreEqual(expectedImageUrl, product.ImageUrl);
    }

    [TestMethod]
    [DataRow("https://example.com/laptop.jpg")]
    [DataRow("https://cdn.example.com/products/mouse.png")]
    [DataRow("/images/keyboard.jpg")]
    [DataRow("image.jpg")]
    [DataRow("")]
    [DataRow(null)]
    public void ImageUrl_SetVariousValues_ReturnsSetValue(string? imageUrl)
    {
        // Arrange
        var product = new Product();

        // Act
        product.ImageUrl = imageUrl;

        // Assert
        Assert.AreEqual(imageUrl, product.ImageUrl);
    }

    [TestMethod]
    public void ImageUrl_SetEmptyString_ReturnsEmptyString()
    {
        // Arrange
        var product = new Product();

        // Act
        product.ImageUrl = string.Empty;

        // Assert
        Assert.AreEqual(string.Empty, product.ImageUrl);
    }

    [TestMethod]
    public void ImageUrl_SetNull_ReturnsNull()
    {
        // Arrange
        var product = new Product();

        // Act
        product.ImageUrl = null;

        // Assert
        Assert.IsNull(product.ImageUrl);
    }

    #endregion

    #region Complete Object Tests

    [TestMethod]
    public void Product_SetAllProperties_ReturnsAllSetValues()
    {
        // Arrange
        var product = new Product();
        var expectedId = 1;
        var expectedName = "Test Product";
        var expectedDescription = "Test Description";
        var expectedPrice = 49.99m;
        var expectedImageUrl = "https://example.com/test.jpg";

        // Act
        product.Id = expectedId;
        product.Name = expectedName;
        product.Description = expectedDescription;
        product.Price = expectedPrice;
        product.ImageUrl = expectedImageUrl;

        // Assert
        Assert.AreEqual(expectedId, product.Id);
        Assert.AreEqual(expectedName, product.Name);
        Assert.AreEqual(expectedDescription, product.Description);
        Assert.AreEqual(expectedPrice, product.Price);
        Assert.AreEqual(expectedImageUrl, product.ImageUrl);
    }

    [TestMethod]
    [DataRow(1, "Laptop", "Gaming laptop", 999.99, "laptop.jpg")]
    [DataRow(2, "Mouse", "Wireless mouse", 29.99, "mouse.jpg")]
    [DataRow(3, "Keyboard", "Mechanical keyboard", 149.99, "keyboard.jpg")]
    [DataRow(4, "Monitor", "4K Monitor", 599.99, "monitor.jpg")]
    [DataRow(5, "Headset", "Gaming headset", 79.99, "headset.jpg")]
    public void Product_SetAllPropertiesWithDataRow_ReturnsAllSetValues(
        int id, string name, string description, double priceValue, string imageUrl)
    {
        // Arrange
        var product = new Product();
        var price = (decimal)priceValue;

        // Act
        product.Id = id;
        product.Name = name;
        product.Description = description;
        product.Price = price;
        product.ImageUrl = imageUrl;

        // Assert
        Assert.AreEqual(id, product.Id);
        Assert.AreEqual(name, product.Name);
        Assert.AreEqual(description, product.Description);
        Assert.AreEqual(price, product.Price);
        Assert.AreEqual(imageUrl, product.ImageUrl);
    }

    [TestMethod]
    public void Product_InitializeWithObjectInitializer_SetsAllProperties()
    {
        // Arrange & Act
        var product = new Product
        {
            Id = 10,
            Name = "Object Initializer Test",
            Description = "Testing object initializer",
            Price = 199.99m,
            ImageUrl = "test.jpg"
        };

        // Assert
        Assert.AreEqual(10, product.Id);
        Assert.AreEqual("Object Initializer Test", product.Name);
        Assert.AreEqual("Testing object initializer", product.Description);
        Assert.AreEqual(199.99m, product.Price);
        Assert.AreEqual("test.jpg", product.ImageUrl);
    }

    #endregion
}
