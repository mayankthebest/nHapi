using System;
using System.Collections.Generic;
using NHapi.Base.Log;
using NHapi.Model.V27.Group;
using NHapi.Model.V27.Segment;
using NHapi.Model.V27.Datatype;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;

namespace NHapi.Model.V27.Message

{
///<summary>
/// Represents a OSM_R26 message structure (see chapter 7.18.1). This structure contains the 
/// following elements:
///<ol>
///<li>0: MSH (Message Header) </li>
///<li>1: SFT (Software Segment) optional repeating</li>
///<li>2: UAC (User Authentication Credential Segment) optional </li>
///<li>3: OSM_R26_SHIPMENT (a Group object) repeating</li>
///</ol>
///</summary>
[Serializable]
public class OSM_R26 : AbstractMessage  {

	///<summary> 
	/// Creates a new OSM_R26 Group with custom IModelClassFactory.
	///</summary>
	public OSM_R26(IModelClassFactory factory) : base(factory){
	   init(factory);
	}

	///<summary>
	/// Creates a new OSM_R26 Group with DefaultModelClassFactory. 
	///</summary> 
	public OSM_R26() : base(new DefaultModelClassFactory()) { 
	   init(new DefaultModelClassFactory());
	}

	///<summary>
	/// initalize method for OSM_R26.  This does the segment setup for the message. 
	///</summary> 
	private void init(IModelClassFactory factory) {
	   try {
	      this.add(typeof(MSH), true, false);
	      this.add(typeof(SFT), false, true);
	      this.add(typeof(UAC), false, false);
	      this.add(typeof(OSM_R26_SHIPMENT), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating OSM_R26 - this is probably a bug in the source code generator.", e);
	   }
	}


	public override string Version
		{
			get{
			return Constants.VERSION;
			}
		}
	///<summary>
	/// Returns MSH (Message Header) - creates it if necessary
	///</summary>
	public MSH MSH { 
get{
	   MSH ret = null;
	   try {
	      ret = (MSH)this.GetStructure("MSH");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns  first repetition of SFT (Software Segment) - creates it if necessary
	///</summary>
	public SFT GetSFT() {
	   SFT ret = null;
	   try {
	      ret = (SFT)this.GetStructure("SFT");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of SFT
	/// * (Software Segment) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public SFT GetSFT(int rep) { 
	   return (SFT)this.GetStructure("SFT", rep);
	}

	/** 
	 * Returns the number of existing repetitions of SFT 
	 */ 
	public int SFTRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("SFT").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the SFT results 
	 */ 
	public IEnumerable<SFT> SFTs 
	{ 
		get
		{
			for (int rep = 0; rep < SFTRepetitionsUsed; rep++)
			{
				yield return (SFT)this.GetStructure("SFT", rep);
			}
		}
	}

	///<summary>
	///Adds a new SFT
	///</summary>
	public SFT AddSFT()
	{
		return this.AddStructure("SFT") as SFT;
	}

	///<summary>
	///Removes the given SFT
	///</summary>
	public void RemoveSFT(SFT toRemove)
	{
		this.RemoveStructure("SFT", toRemove);
	}

	///<summary>
	///Removes the SFT at the given index
	///</summary>
	public void RemoveSFTAt(int index)
	{
		this.RemoveRepetition("SFT", index);
	}

	///<summary>
	/// Returns UAC (User Authentication Credential Segment) - creates it if necessary
	///</summary>
	public UAC UAC { 
get{
	   UAC ret = null;
	   try {
	      ret = (UAC)this.GetStructure("UAC");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns  first repetition of OSM_R26_SHIPMENT (a Group object) - creates it if necessary
	///</summary>
	public OSM_R26_SHIPMENT GetSHIPMENT() {
	   OSM_R26_SHIPMENT ret = null;
	   try {
	      ret = (OSM_R26_SHIPMENT)this.GetStructure("SHIPMENT");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of OSM_R26_SHIPMENT
	/// * (a Group object) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public OSM_R26_SHIPMENT GetSHIPMENT(int rep) { 
	   return (OSM_R26_SHIPMENT)this.GetStructure("SHIPMENT", rep);
	}

	/** 
	 * Returns the number of existing repetitions of OSM_R26_SHIPMENT 
	 */ 
	public int SHIPMENTRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("SHIPMENT").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the OSM_R26_SHIPMENT results 
	 */ 
	public IEnumerable<OSM_R26_SHIPMENT> SHIPMENTs 
	{ 
		get
		{
			for (int rep = 0; rep < SHIPMENTRepetitionsUsed; rep++)
			{
				yield return (OSM_R26_SHIPMENT)this.GetStructure("SHIPMENT", rep);
			}
		}
	}

	///<summary>
	///Adds a new OSM_R26_SHIPMENT
	///</summary>
	public OSM_R26_SHIPMENT AddSHIPMENT()
	{
		return this.AddStructure("SHIPMENT") as OSM_R26_SHIPMENT;
	}

	///<summary>
	///Removes the given OSM_R26_SHIPMENT
	///</summary>
	public void RemoveSHIPMENT(OSM_R26_SHIPMENT toRemove)
	{
		this.RemoveStructure("SHIPMENT", toRemove);
	}

	///<summary>
	///Removes the OSM_R26_SHIPMENT at the given index
	///</summary>
	public void RemoveSHIPMENTAt(int index)
	{
		this.RemoveRepetition("SHIPMENT", index);
	}

}
}
