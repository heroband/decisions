using lab5;

IRenderer htmlRenderer = new HTMLRenderer();
IRenderer jsonRenderer = new JsonRenderer();
IRenderer xmlRenderer = new XmlRenderer();

Page simplePage = new SimplePage("Welcome", "This is a simple page.", htmlRenderer);
simplePage.Render();


Product product = new Product
{
    Name = "Smartphone",
    Description = "Latest model",
    ImageUrl = "http://localStorage/someImage.jpg",
    Id = 123
};

Page productPage = new ProductPage(product, jsonRenderer);
productPage.Render();

productPage = new ProductPage(product, xmlRenderer);
productPage.Render();