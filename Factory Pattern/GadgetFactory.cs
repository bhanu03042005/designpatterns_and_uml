namespace GadgetHub 
{
    public class GadgetFactory 
    {
       public static Gadget GetGadget(string type, string name){
        if(type.Equals("mobile",StringComparison.OrdinalIgnoreCase)){
            return new MobileGadget(name);
        }
        else if(type.Equals("laptop",StringComparison.OrdinalIgnoreCase)){
            return new LaptopGadget(name);
        }
        else{
            Console.WriteLine("Invalid gadget type");
            return null;
        }
        }

 
    }
}
