//------------------------------------------------------------------------------------------------------------------------
//Before C# version 10
//------------------------------------------------------------------------------------------------------------------------

//ProvinceOrStateTaxProperty class0 = new();

//class0.ProvinceOrState = "Province";

//CalculateTax class1 = new();

//class1.CountryName = "USA";

//class1.ProvinceTaxProperty = class0;

//class1.ProvinceTaxProperty.ProvinceOrState = "Alberta";
//Computing class2 = new();

//decimal result = class2.ComputePrice(class1, 10);

//Console.WriteLine(result);

//------------------------------------------------------------------------------------------------------------------------
//------------------------------------------------------------------------------------------------------------------------

//public class ProvinceOrStateTaxProperty
//{
//    public string ProvinceOrState { get; set; }
//}

//public class CalculateTax
//{
//    public string CountryName { get; set; }
//    public ProvinceOrStateTaxProperty ProvinceTaxProperty { get; set; }
//}

//public class Computing
//{
//    public decimal ComputePrice(CalculateTax calculate, decimal price) =>

//    calculate switch
//    {

//        { ProvinceTaxProperty: { ProvinceOrState: "Québec" } } => 1.14975M * price,

//        { ProvinceTaxProperty: { ProvinceOrState: "Alberta" } } => 1.05M * price,

//        { ProvinceTaxProperty: { ProvinceOrState: "Ontario" } } => 1.13M * price,

//        _ => 0

//    };
//}

//------------------------------------------------------------------------------------------------------------------------
//After C# version 10
//------------------------------------------------------------------------------------------------------------------------

ProvinceOrStateTaxProperty class0 = new();
class0.ProvinceOrState = "Province";

ProvinceOrStateTax class1 = new();
class1.ProvinceOrState = "Ontario";

CountryTax class2 = new();
class2.CountryName = "USA";
class2.ProvinceTaxProperty = class1;

decimal result = Computing.ComputePrice(class2, 100);

Console.WriteLine(result);

//------------------------------------------------------------------------------------------------------------------------
//------------------------------------------------------------------------------------------------------------------------

public class ProvinceOrStateTaxProperty
{
    public string ProvinceOrState { get; set; }
}

public class ProvinceOrStateTax
{
    public string ProvinceOrState { get; set; }
}

public class CountryTax
{
    public string CountryName { get; set; }
    public ProvinceOrStateTax ProvinceTaxProperty { get; set; }
}

public class Computing
{
    public static decimal ComputePrice(CountryTax calculate, decimal price) => calculate switch
    {

        { ProvinceTaxProperty.ProvinceOrState: "Québec" } => 1.14975M * price,

        { ProvinceTaxProperty.ProvinceOrState: "Alberta" } => 1.05M * price,

        { ProvinceTaxProperty.ProvinceOrState: "Ontario" } => 1.13M * price,

        _ => 0

    };
}