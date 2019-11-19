﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

public partial class BSTLOG
{
	public long ID { get; set; }
	public Nullable<System.DateTime> DATETIME { get; set; }
	public string TEXT { get; set; }
	public int USERID { get; set; }

	public virtual PERSON PERSON { get; set; }
}

public partial class FIPVERSION
{
	[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
	public FIPVERSION()
	{
		this.TESTREQUESTS = new HashSet<TESTREQUEST>();
	}

	public int ID { get; set; }
	public string VERSION { get; set; }
	public string COMMENT { get; set; }
	public Nullable<int> OFFICIAL { get; set; }

	[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
	public virtual ICollection<TESTREQUEST> TESTREQUESTS { get; set; }
}

public partial class PC
{
	[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
	public PC()
	{
		this.SCHEDULEs = new HashSet<SCHEDULE>();
		this.SCHEDULEs1 = new HashSet<SCHEDULE>();
	}

	public int ID { get; set; }
	public string PCNAME { get; set; }
	public string PCIP { get; set; }
	public bool UNUSED { get; set; }
	public string IPCONFIG { get; set; }
	public string PCINFO { get; set; }
	public Nullable<System.DateTime> STARTED { get; set; }
	public string CURRENT { get; set; }
	public Nullable<int> LEFTINSEQUENCE { get; set; }
	public Nullable<System.DateTime> PCPING { get; set; }
	public Nullable<double> DISKSSIZE { get; set; }
	public Nullable<System.DateTime> SS_CODE { get; set; }
	public Nullable<int> VERSION { get; set; }
	public Nullable<int> TESTCASE_ID { get; set; }
	public Nullable<int> PAUSEDBY { get; set; }
	public string COMMITHASH { get; set; }
	public Nullable<bool> COMMITFILES { get; set; }
	public Nullable<int> STOP { get; set; }
	public Nullable<int> ACTIONFLAG { get; set; }
	public string DBTYPE { get; set; }
	public Nullable<int> REQUEST_ID { get; set; }
	public string COMMITFILESLIST { get; set; }
	public Nullable<bool> PHYSICAL { get; set; }
	public Nullable<bool> NO3DV { get; set; }
	public string PARENT_PC { get; set; }
	public Nullable<int> HOST_ID { get; set; }
	public Nullable<System.DateTime> LAST_UPDATED { get; set; }
	public Nullable<int> SCHEDULES { get; set; }

	public virtual TESTREQUEST TESTREQUEST { get; set; }
	public virtual PERSON PERSON { get; set; }
	[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
	public virtual ICollection<SCHEDULE> SCHEDULEs { get; set; }
	[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
	public virtual ICollection<SCHEDULE> SCHEDULEs1 { get; set; }
}

public partial class PERSON
{
	[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
	public PERSON()
	{
		this.PCS = new HashSet<PC>();
		this.TESTREQUESTS = new HashSet<TESTREQUEST>();
		this.TESTREQUESTS1 = new HashSet<TESTREQUEST>();
		this.BSTLOGs = new HashSet<BSTLOG>();
		this.SCHEDULEs = new HashSet<SCHEDULE>();
	}

	public int ID { get; set; }
	public string USER_NAME { get; set; }
	public string USER_LOGIN { get; set; }
	public string USER_PASS { get; set; }
	public bool IS_ADMIN { get; set; }
	public bool IS_GUEST { get; set; }
	public Nullable<bool> RETIRED { get; set; }
	public string PHONE { get; set; }

	[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
	public virtual ICollection<PC> PCS { get; set; }
	[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
	public virtual ICollection<TESTREQUEST> TESTREQUESTS { get; set; }
	[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
	public virtual ICollection<TESTREQUEST> TESTREQUESTS1 { get; set; }
	[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
	public virtual ICollection<BSTLOG> BSTLOGs { get; set; }
	[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
	public virtual ICollection<SCHEDULE> SCHEDULEs { get; set; }
}

public partial class SCHEDULE
{
	public int ID { get; set; }
	public string COMMAND { get; set; }
	public Nullable<int> REQUESTID { get; set; }
	public Nullable<int> PCID { get; set; }
	public Nullable<int> USERID { get; set; }
	public Nullable<int> SEQUENCENUMBER { get; set; }
	public Nullable<int> PRIORITY { get; set; }
	public Nullable<int> LOCKEDBY { get; set; }
	public string SEQUENCEGUID { get; set; }
	public string DBTYPE { get; set; }
	public Nullable<bool> Y3DV { get; set; }

	public virtual PC PC { get; set; }
	public virtual PC PC1 { get; set; }
	public virtual PERSON PERSON { get; set; }
	public virtual SCHEDULE SCHEDULE1 { get; set; }
	public virtual SCHEDULE SCHEDULE2 { get; set; }
	public virtual TESTREQUEST TESTREQUEST { get; set; }
}

public partial class TESTREQUEST
{
	[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
	public TESTREQUEST()
	{
		this.PCS = new HashSet<PC>();
		this.SCHEDULEs = new HashSet<SCHEDULE>();
	}

	public int ID { get; set; }
	public string TTID { get; set; }
	public string GUID { get; set; }
	public Nullable<System.DateTime> RequestDateTime { get; set; }
	public Nullable<int> UserID { get; set; }
	public string ProgAbb { get; set; }
	public string Comment { get; set; }
	public Nullable<int> VersionID { get; set; }
	public Nullable<bool> IGNORE { get; set; }
	public Nullable<bool> TESTED { get; set; }
	public string GITHASH { get; set; }
	public Nullable<int> REQUEST_PRIORITY { get; set; }
	public Nullable<int> TESTERID { get; set; }

	public virtual FIPVERSION FIPVERSION { get; set; }
	[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
	public virtual ICollection<PC> PCS { get; set; }
	public virtual PERSON PERSON { get; set; }
	public virtual PERSON PERSON1 { get; set; }
	[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
	public virtual ICollection<SCHEDULE> SCHEDULEs { get; set; }
}
