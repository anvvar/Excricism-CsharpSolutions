using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
public class FacialFeatures
{
    public string EyeColor { get; }
    public decimal PhiltrumWidth { get; }

    public FacialFeatures(string eyeColor, decimal philtrumWidth)
    {
        EyeColor = eyeColor;
        PhiltrumWidth = philtrumWidth;
    }
    // TODO: implement equality and GetHashCode() methods
    public override bool Equals(object obj)
    {
        if (obj == null)
        {
            return false;
        }
        FacialFeatures other = (FacialFeatures)obj;
        return EyeColor == other.EyeColor && PhiltrumWidth == other.PhiltrumWidth;
    }

    public override int GetHashCode()
    {
        unchecked
        {
            int hash = 17;
            hash = hash * 23 + EyeColor.GetHashCode();
            hash = hash * 23 + PhiltrumWidth.GetHashCode();
            return hash;
        }
    }
}

public class Identity
{
    public string Email { get; }
    public FacialFeatures FacialFeatures { get; }

    public Identity(string email, FacialFeatures facialFeatures)
    {
        Email = email;
        FacialFeatures = facialFeatures;
    }
    // TODO: implement equality and GetHashCode() methods
    public override bool Equals(object obj)
    {
        if (obj == null)
        {
            return false;
        }
        Identity other = (Identity)obj;
        return Email == other.Email && FacialFeatures.Equals(other.FacialFeatures);
    }

    public override int GetHashCode()
    {
        unchecked
        {
            int hash = 17;
            hash = hash * 23 + Email.GetHashCode();
            hash = hash * 23 + FacialFeatures.GetHashCode();
            return hash;
        }
    }

}

public class Authenticator
{
    private HashSet<Identity> registeredIdentities;
    public Authenticator()
    {
        registeredIdentities = new HashSet<Identity>();
    }
    public static bool AreSameFace(FacialFeatures faceA, FacialFeatures faceB)
    {
        return faceA.Equals(faceB);
    }
    public bool IsAdmin(Identity identity)
    {
        Identity adminIdentity = new Identity("admin@exerc.ism", new FacialFeatures("green", 0.9m));
        return identity.Equals(adminIdentity);
    }

    public bool Register(Identity identity)
    {
        if (registeredIdentities.Contains(identity))
        {
            return false;
        }

        registeredIdentities.Add(identity);
        return true;
    }

    public bool IsRegistered(Identity identity)
    {
        return registeredIdentities.Contains(identity);
    }

    public static bool AreSameObject(Identity identityA, Identity identityB)
    {
        return ReferenceEquals(identityA, identityB);
    }
}
