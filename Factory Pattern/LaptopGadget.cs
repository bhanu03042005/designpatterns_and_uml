namespace GadgetHub 
{
    public class LaptopGadget : Gadget 
    {
       public LaptopGadget(string name){
           this.gadgetName=name;
           Console.WriteLine($"You have chosen Laptop Gadget and its name is {this.gadgetName}");
       }
    }
}
