using System;
static class QuestLogic
{
    
    public static bool CanFastAttack(bool knightIsAwake)
    {
        
            if(knightIsAwake ==false)
                return true;
            else
            return false;
 }
    

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
    if( knightIsAwake==true )
       if(archerIsAwake==true && prisonerIsAwake==true)
                 return true;
       else if(archerIsAwake==false || prisonerIsAwake==false)
                 return true;
        else
            return false;
    else if (archerIsAwake==true)
             if(  knightIsAwake==false || prisonerIsAwake==false)
            return true;
        else
            return false;
     else if ( prisonerIsAwake==true)
             if(  knightIsAwake==false || archerIsAwake==false)
            return true;
             else
            return false;
        else
            return false;
    }

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
       
        if(archerIsAwake==false && prisonerIsAwake==true)
                  return true;
        else
            return false;
        
    }

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
      
        if ( petDogIsPresent==true)
          if( archerIsAwake==false )
                 return true;
          else return false;
        else if ( petDogIsPresent==false)
          if( knightIsAwake==false && archerIsAwake==false && prisonerIsAwake==true)
                 return true;
                  else 
              return false;
        else 
            return false;
        
    }
}
