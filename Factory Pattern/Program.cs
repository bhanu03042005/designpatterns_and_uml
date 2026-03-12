namespace GadgetHub
{ 
    public class Program
    {
       public static void Main(string[] args) 
        {
           Console.WriteLine("Enter the gadget type (mobile/laptop):");
           string type=Console.ReadLine();
           Console.WriteLine("Enter the name of the gadget:");
           string name=Console.ReadLine();
           Gadget gadget=GadgetFactory.GetGadget(type,name);
           if(gadget != null){
             Console.WriteLine($"Gadget created: {gadget.gadgetName}");
           }
        }
    }
}
