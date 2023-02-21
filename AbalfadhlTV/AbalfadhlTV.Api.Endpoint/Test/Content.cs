///////////////////////////////////////////////////////////
//  Content.cs
//  Implementation of the Class Content
//  Generated by Enterprise Architect
//  Created on:      09-������-2022 10:08:48 �.�
//  Original author: razi
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



/// <summary>
/// <p align="right" dir="rtl"><span dir="rtl">�����</span></p>
/// </summary>
public class Content {

	/// <summary>
	/// <p align="right" dir="rtl"><span dir="rtl">���� ����</span></p>
	/// </summary>
	public int Id;
	/// <summary>
	/// <p align="right" dir="rtl"><span dir="rtl">���</span><span
	/// dir="ltr">/</span><span dir="rtl">�����</span>
	/// </p><p dir="rtl"></p>
	/// </summary>
	public string Title;
	/// <summary>
	/// <p align="right" dir="rtl"><span dir="rtl">�������</span>
	/// </p><p dir="rtl"></p>
	/// </summary>
	public string Description;
	/// <summary>
	/// <p align="right" dir="rtl"><span dir="rtl">�� �����</span>
	/// </p><p dir="rtl"></p>
	/// </summary>
	public string ContentCode;
	/// <summary>
	/// <p align="right" dir="rtl"><span dir="rtl">��� ���</span></p>
	/// </summary>
	public bool Deleted;
	/// <summary>
	/// <p align="right" dir="rtl"><span dir="rtl">����</span></p>
	/// </summary>
	public bool Active;
	/// <summary>
	/// <p align="right" dir="rtl"><span dir="rtl">����</span></p>
	/// </summary>
	public binary File;
	/// <summary>
	/// <p align="right" dir="rtl"><span dir="rtl">���� ����</span>
	/// </p><p dir="rtl"></p>
	/// </summary>
	public string FileAddress;
	/// <summary>
	/// <p align="right" dir="rtl"><span dir="rtl">����</span><span
	/// dir="ltr">/</span><span dir="rtl">���</span><span dir="rtl">����</span>
	/// </p><p dir="rtl"></p>
	/// </summary>
	public double FileSize;
	/// <summary>
	/// <p align="right" dir="rtl"><span dir="rtl">��� �����</span>
	/// </p><p align="right" dir="rtl">
	/// </p><p align="right" dir="rtl"></p>
	/// </summary>
	public Enumerations.ContentTypeENUM ContentType;
	/// <summary>
	/// <p align="right" dir="rtl"><span dir="rtl">���� �����</span>
	/// </p><p align="right" dir="rtl"></p>
	/// </summary>
	public bool CanBeSavedAs;
	/// <summary>
	/// <p align="right" dir="rtl"><span dir="rtl">���� ������</span>
	/// </p><p align="right" dir="rtl"></p>
	/// </summary>
	public bool CanDownload;
	/// <summary>
	/// <p align="right" dir="rtl"><span dir="rtl">����</span></p>
	/// </summary>
	public Enumerations.LanguageENUM Language;
	/// <summary>
	/// <p align="right" dir="rtl"><span dir="rtl">���</span>
	/// </p><p align="right" dir="rtl"></p>
	/// </summary>
	public binary Icon;

	public Content(){

	}

	~Content(){

	}

}//end Content