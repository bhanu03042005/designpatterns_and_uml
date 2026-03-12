namespace GadgetHub
{
    public class MobileGadget : Gadget 
    {
       public MobileGadget(string name){
           this.gadgetName=name;
           Console.WriteLine($"You have chosen Mobile Gadget and its name is {this.gadgetName}");
       }
    }
}
