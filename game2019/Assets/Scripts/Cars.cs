using System;

class Cars
{
    public int ID { get; private set; }
    public string Name { get; private set; }
    public Cars(int id, string name)
    {
        ID = id;
        Name = name;
    }
    public Cars() { }
    public void SetIdAndName(string name)
    {
        ID = Convert.ToInt32(name.Substring(0, name.IndexOf(".")));
        Name = name.Substring(name.IndexOf('.') + 1, name.Length - name.IndexOf(".") - 1);
    }
}
