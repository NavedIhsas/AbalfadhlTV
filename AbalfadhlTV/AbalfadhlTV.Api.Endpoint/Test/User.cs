///////////////////////////////////////////////////////////
//  User.cs
//  Implementation of the Class User
//  Generated by Enterprise Architect
//  Created on:      09-������-2022 10:08:48 �.�
//  Original author: razi
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using Gift;
using Education;
using Communications;
using Loyalty;
using Pilgrimage;
/// <summary>
/// <p align="right" dir="rtl"><span dir="rtl">�����</span>
/// </p><p align="right" dir="rtl"></p>
/// </summary>
public class User : Person {

	/// <summary>
	/// <p align="right" dir="rtl"><span dir="rtl">���� ����</span></p>
	/// </summary>
	public int Id;
	/// <summary>
	/// <p align="right" dir="rtl"><span dir="rtl">�� �����</span></p>
	/// </summary>
	public int UserCode;
	/// <summary>
	/// <p align="right" dir="rtl"><span dir="rtl">��� �����</span></p>
	/// </summary>
	public Enumerations.UserTypeENUM UserType;
	/// <summary>
	/// <p align="right" dir="rtl"><span dir="rtl">����� � ���� �����</span></p>
	/// </summary>
	public DateTime CreationDateTime;
	/// <summary>
	/// <p align="right" dir="rtl"><span dir="rtl">��� ������</span>
	/// </p><p dir="rtl"></p>
	/// </summary>
	public string Alias;
	/// <summary>
	/// <p align="right" dir="rtl"><span dir="rtl">����� ������</span>
	/// </p><p dir="rtl"></p>
	/// </summary>
	public string Usename;
	/// <summary>
	/// <p align="right" dir="rtl"><span dir="rtl">��� ����</span>
	/// </p><p dir="rtl"></p>
	/// </summary>
	public string Password;
	/// <summary>
	/// <p align="right" dir="rtl"><span dir="rtl">����</span>
	/// </p><p dir="rtl"></p>
	/// </summary>
	public bool Active;
	/// <summary>
	/// <p align="right" dir="rtl"><span dir="rtl">����� ����</span></p>
	/// </summary>
	public int RepresentativeUser;
	/// <summary>
	/// <p align="right" dir="rtl"><span dir="rtl">��� ���</span>
	/// </p><p align="right" dir="rtl"></p>
	/// </summary>
	public bool Deleted;
	/// <summary>
	/// <p align="right" dir="rtl"><span dir="rtl">�������</span>
	/// </p><p dir="rtl"></p>
	/// </summary>
	public string Description;
	public Gift.BuyGift m_BuyGift;
	public Education.Register m_Register;
	private UserGroup m_UserGroup;
	public UserLoginLogout m_UserLoginLogout;
	public Privilege m_Privilege;
	public User m_User;
	public Communications.DirectCommunication m_DirectCommunication;
	public Loyalty.PrivilegeCalculation m_PrivilegeCalculation;
	public Pilgrimage.Pilgrimage m_Pilgrimage;
	public Pilgrimage.VicariousPilgrimageRequest m_VicariousPilgrimageRequest;

	public User(){

	}

	~User(){

	}

}//end User