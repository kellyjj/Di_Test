using System;

namespace DI_test
{

    public interface Irose 
    {
        public void displaymesg();
    }

    public class cantoi:Irose
    {
        public string themesg;
        
        public void displaymesg()
        {
            Console.WriteLine("This is the Cantoi "+ themesg);
        }

        public cantoi(string val)
        {
            themesg = val;
        }
    }


    public class tower:Irose
    {
        /*  this class is where we have the dependacy inject happen.  since I could use either tower or cantoi  I use a interface, and pass that along.  
            that then allows me to interchange my classes.   
        */
        public string themesg;
        
        public void displaymesg()
        {
            Console.WriteLine("this is the tower "+ themesg);
        }

        public tower(string val)
        {
            themesg = val;
        }
    }


    public class ShowMesg
    {
        Irose tw ;

        public void displaymesg()
        {

        }

        public ShowMesg(Irose therose)
        {
            tw = therose;
            tw.displaymesg();
        }
    }
    
}