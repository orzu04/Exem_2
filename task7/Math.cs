


public class Math
{
    public double Pi;
    public double E;
    public double D;
    public double X;
      public double Y;


    public double Abs(double value)
    {
        if(value<0)
        {
            return value*(-1);
        }
        else
        {
            return value;
        }
        Pi = value;


    }
    public float Float (float value)
    {
          if(value<0)
        {
            return value*(-1);
        }
        else
        {
            return value;
        }
        Pi = value;
    }

     public int Int(int value)
     {
              if(value<0)
        {
            return value*(-1);
        }
        else
        {
            return value;
        }
        Pi = value;
     }
     public double Pow (double x, double y)
     {
           double S=x;
        
        for (int i = 0; i <= y ; i++)
     
        {

             S*=i;
        }
        return S;
          
          X=x;
          y = y;

     }

     public double Sqrt(double d)
     {
     
        for (int i = 0; i <=d ; i++)
        {
            i*=i;
            if(i==d)
            {
                return i;
            }
            else {
                return 0;
            }
        }
        
       
     }

     public int Max(int val1, int val2)
     {
       
        if(val1>val2)
        {
            return val1;
        }
        else
         {
            return val2;
         }

         Pi = val1;
        E = val2;
     }
     public int Min (int val1, int val2)
     {
        if (val1<val2)
        {
            return val1;

        }
        else{
            return val2;
        }
        Pi = val1;
        E = val2;
     }



}