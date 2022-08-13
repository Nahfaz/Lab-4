using System;

public class Car
{

    #region Properties


    private int Count = 0;
    private int IdentificationNumber = 0;
    private string Make = string.Empty;
    private string Model = string.Empty;
    private int Year = 0;
    private decimal Price = 0m;
    private bool Newstatus = false;

    #endregion

    #region constructor
    /// <summary>
    /// create a new car using default value
    /// </summary>
    public Car()
    {
        IdentificationNumber = Count;
        Count += 1;


    }

    /// <summary>
    /// create a new car using provided value
    /// </summary>
    /// <param name="make"></param>
    /// <param name="model"></param>
    /// <param name="year"></param>
    /// <param name="price"></param>
    /// <param name="newstatus"></param>
    public Car(string make, string model, string year, string price, bool newstatus)
    {
        IdentificationNumber = Count;
        Count += 1;
        Make = make;
        Model = model;
        Year = Convert.ToInt32(year);

        Price = Convert.ToDecimal(price);
        Newstatus = newstatus;

    }

    #endregion

    #region Methods
    public string CarMake
    {
        get
        {
            return Make;

        }
        set
        {
            Make = value;

        }


    }

    public string CarModel
    {
        get
        {
            return Model;
        }
        set
        {
            Model = value;
        }
    }

    public int CarYear
    {
        get
        {
            return Year;

        }
        set
        {
            Year = value;

        }
    }

    public decimal CarPrice
    {
        get
        {
            return Price;
        }
        set
        {
            Price = value;

        }
    }


    public bool CarNewStatus
    {
        get
        {
            return Newstatus;
        }
        set
        {
            Newstatus = value;

        }
    }

    public int CarIdentificationNumber
    {
        get
        {
            return IdentificationNumber;
        }
    }

    public int CarCount
    {
        get
        {
            return Count;
        }
    }
    #endregion

}

