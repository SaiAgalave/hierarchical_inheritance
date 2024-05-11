using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace hierarchical_inheritance
{
    public  class Vehical
    {
        private string model;
        private int registration_number;
        private int vehical_speed;
        private int fuel_capacity;
        private int fuel_consumption;
        public Vehical( string mod,int re_no,int v_speed,int f_cap,int f_con)
        {
            model = mod;
            registration_number = re_no;
            vehical_speed = v_speed;
            fuel_capacity = f_cap;
            fuel_consumption = f_con;
        }
        public void setmodel(string mod)
        {
            model = mod;
        }
        public string getmodel() 
        {
            return model;
        }
        public void setre_no(int rg)
        {
            registration_number = rg;
        }
        public int getre_no()
        {
            return registration_number;
        }
        public void setv_speed(int vs)
        {
            vehical_speed=vs;
        }
        public int  getv_speed()
        {
            return vehical_speed ;
        }
        public void setfuel_cap(int fcap)
        {
            fuel_capacity=fcap;
        }
        public int getfuel_cap()
        {
            return fuel_capacity;
        }
        public void setfuel_con(int fcons)
        {
            fuel_consumption=fcons;
        }
        public int  getfuel_con()
        {
            return fuel_consumption;
        }
        public int  fuelNeeded(int distance)
        {
            int fNeed = 0;
            fNeed = distance / fuel_consumption;
            return fNeed;
        }
        public int distanceCovered(int time)
        {
            int distance = 0;
            distance = vehical_speed * time;
            return distance;
        }
        virtual public void display()
        {
            Console.WriteLine("Model of Vehical-->"+model);
            Console.WriteLine("Registration number-->"+registration_number);
            Console.WriteLine("Vehical Speed-->"+vehical_speed);
            Console.WriteLine("Fuel capacity-->"+fuel_capacity);
            Console.WriteLine("Fuel Consumption"+fuel_consumption);
        }
    }
    public class  Bus:Vehical
    {
        private int no_0f_passenger;
        public Bus(int nopass, string mod, int re_no, int v_speed, int f_cap, int f_con):base(mod,re_no,v_speed,f_cap,f_con)
        {
            no_0f_passenger= nopass;
        }
        public void set(int np)
        {
            no_0f_passenger = np;   
        }
        public int get()
        {
            return no_0f_passenger;
        }
        override public void display()
        {
            base.display();
            Console.WriteLine("Number of Passenger" +no_0f_passenger);
        }

    }
    public  class Truck:Vehical
    {
        int cargo_wt_limit;
        public void setcargo_wt_limit(int cwt )
        {
            cargo_wt_limit = cwt;   
        }
        public int getcargo_wt_limit()
        {
            return cargo_wt_limit;
        }
        public Truck(int cwl, string mod, int re_no, int v_speed, int f_cap, int f_con):base(mod,re_no,v_speed,f_cap,f_con)
        {
            cargo_wt_limit= cwl;    
        }

        public void set(int cwl )
        {
            cargo_wt_limit=cwl;
        }
        public int get()
        {
            return cargo_wt_limit;
        }
        override public void display()
        {
            base.display();
            Console.WriteLine("Cargo wait limit"+cargo_wt_limit);
        }
    }
}
