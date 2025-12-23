using System.Xml;
namespace XMLer
{
class XMiLier
    {
    static void Main()
        {
       var reader = XmlReader.Create("products.xml");
        reader.ReadToFollowing("product");
       do{
       reader.MoveToFirstAttribute();
       System.Console.WriteLine(reader.Value);
       reader.ReadToFollowing("name");
       System.Console.WriteLine(reader.ReadElementContentAsString());
       reader.ReadToNextSibling("price");
       System.Console.WriteLine(reader.ReadElementContentAsString());
       } while( reader.ReadToFollowing("product"));



        }
    }
}
