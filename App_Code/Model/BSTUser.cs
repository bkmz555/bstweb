﻿public class BSTUser : IdBasedObject
{
	const string _name = "USER_NAME";
	const string _pid = "ID";
	const string _adm = "IS_ADMIN";
	const string _login = "USER_LOGIN";
	const string _pass = "USER_PASS";
	const string _ret = "RETIRED";

	static string[] _allcols = new string[] { _pid, _name, _adm, _login, _pass, _ret };
	public static string _Tabl = "[PERSONS]";

	public string LOGIN
	{
		get { return this[_login].ToString(); }
		set { this[_login] = value; }
	}
	public string USER_NAME
	{
		get { return this[_name].ToString(); }
		set { this[_name] = value; }
	}
	public int ID
	{
		get { return GetAsInt(_adm); }
		set { this[_pid] = value; }
	}
	public bool ISADMIN
	{
		get { return GetAsBool(_adm); }
		set { this[_adm] = value; }
	}
	public bool RETIRED
	{
		get { return GetAsBool(_ret); }
		set { this[_ret] = value; }
	}

	public BSTUser(string id, string name = "")
	  : base(_Tabl, _allcols,
		  string.IsNullOrEmpty(id) ? string.Format("(SELECT [ID] FROM [PERSONS] WHERE [USER_LOGIN] = '{0}')", name) : id)
	{
	}
	public BSTUser(int id)
	  : base(_Tabl, _allcols, id.ToString(), _pid)
	{
	}
	public static BSTUser FindUser(string name, string pass)
	{
		foreach (int i in EnumRecords(_Tabl, _pid, new string[] { _login, _pass }, new object[] { name, pass }))
		{
			return new BSTUser(i);
		}
		return null;
	}
	public static BSTUser FindUserbyID(int id)
	{
		foreach (int i in EnumRecords(_Tabl, _pid, new string[] { _pid }, new object[] { id }))
		{
			return new BSTUser(i);
		}
		return null;
	}
}