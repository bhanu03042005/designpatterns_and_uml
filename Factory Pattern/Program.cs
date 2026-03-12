namespace GadgetHub //Do NOT change the Namespace Name
{ 
    public class Program //Do NOT change the Class Name
    {
       public static void Main(string[] args) //Do NOT change the Method Signature
        {
           // Implement your code here
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
