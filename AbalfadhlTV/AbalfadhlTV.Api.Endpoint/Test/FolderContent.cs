///////////////////////////////////////////////////////////
//  FolderContent.cs
//  Implementation of the Class FolderContent
//  Generated by Enterprise Architect
//  Created on:      09-������-2022 10:08:49 �.�
//  Original author: 0451256107
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



/// <summary>
/// <p align="right" dir="rtl"><span dir="rtl">�����/�����/���� � �����</span>
/// </p><p align="right" dir="rtl"></p>
/// </summary>
public class FolderContent {

	/// <summary>
	/// <p align="right" dir="rtl"><span dir="rtl">���� ����</span></p>
	/// </summary>
	public int Id;
	/// <summary>
	/// <p align="right" dir="rtl"><span dir="rtl">����� ����� ������</span>
	/// </p>
	/// </summary>
	public DateTime CreationDateTime;
	/// <summary>
	/// <p align="right" dir="rtl"><span dir="rtl">����� ������</span></p>
	/// </summary>
	public DateTime ExpirationDateTime;
	private Content m_Content;
	public Folder m_Folder;

	public FolderContent(){

	}

	~FolderContent(){

	}

}//end FolderContent