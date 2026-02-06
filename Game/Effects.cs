namespace Elements{
class StsEff{

static public string Effects(string? status,ref uint timer,ref int statdmg)
{
    switch (status)
    {
    case "ignite":timer=3; statdmg = 4 ; return status;
    case "freeze":timer=2; statdmg =-1; return status;
    
    
    }
    return "None";
}
}
}