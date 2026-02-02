static string Effects(string status,ref int timer,ref int statdmg)
{
    switch (status)
    {
    case "ignite": if(timer!=0){timer++;}else{timer=3;} statdmg = 4 ;break;
    }
    return "None";
};
