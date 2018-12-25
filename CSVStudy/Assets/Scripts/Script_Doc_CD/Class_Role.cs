using UnityEngine; 
using System.Collections; 
public class Class_Role { 
	public string 字段 { get; set; }    //注释
	public string id { get; set; }    //角色ID
	public int _id (){
		int value = int.Parse(id);
		return value;
	}
	public string head { get; set; }    //角色头像
	  public string _head (){
		string value = head;
		return value;
	}
	public string name { get; set; }    //角色名称
	  public string _name (){
		string value = name;
		return value;
	}
	public string gender { get; set; }    //角色性别
	  public string _gender (){
		string value = gender;
		return value;
	}
	}
	