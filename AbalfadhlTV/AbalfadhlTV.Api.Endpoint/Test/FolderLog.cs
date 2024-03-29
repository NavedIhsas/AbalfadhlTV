///////////////////////////////////////////////////////////
//  FolderLog.cs
//  Implementation of the Class FolderLog
//  Generated by Enterprise Architect
//  Created on:      09-������-2022 10:08:50 �.�
//  Original author: razi
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



/// <summary>
/// <p align="right" dir="rtl"><span dir="rtl">�ǐ ����</span>
/// </p><p align="right" dir="rtl"></p>
/// </summary>
public class FolderLog {

	/// <summary>
	/// <p align="right" dir="rtl"><span dir="rtl">���� ����</span></p>
	/// </summary>
	public int Id;
	/// <summary>
	/// <p align="right" dir="rtl"><span dir="rtl">�����</span><span
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
	/// <p align="right" dir="rtl"><span dir="rtl">���</span>
	/// </p><p align="right" dir="rtl"></p>
	/// </summary>
	public binary Icon;
	/// <summary>
	/// <p align="right" dir="rtl"><span dir="rtl">��� ���</span>
	/// </p><p align="right" dir="rtl"></p>
	/// </summary>
	public bool Deleted;
	/// <summary>
	/// <p align="right" dir="rtl"><span dir="rtl">�� �����</span><span
	/// dir="ltr">/</span><span dir="rtl">����</span>
	/// </p><p align="right" dir="rtl">
	/// </p><p dir="rtl"></p>
	/// </summary>
	public int FolderCode;
	/// <summary>
	/// <p align="right" dir="rtl"><span dir="rtl">��� ������ �����/����</span>
	/// </p><p align="right" dir="rtl">
	/// </p><p align="right" dir="rtl"></p>
	/// </summary>
	public Enumerations.FolderAccessENUM FolderAccess;
	/// <summary>
	/// <p align="right" dir="rtl"><span dir="rtl">��� �����</span>
	/// </p><p align="right" dir="rtl"></p>
	/// </summary>
	public Enumerations.ArchiveTypeENUM ArchiveType;
	/// <summary>
	/// <p align="right" dir="rtl"><span dir="rtl">��� ������ ����</span>
	/// </p><p align="right" dir="rtl"></p>
	/// </summary>
	public Enumerations.FolderContentTypeENUM FolderContentType;
	/// <summary>
	/// <p align="right" dir="rtl"><span dir="rtl">����� � ���� �����</span></p>
	/// </summary>
	public DateTime CreationDateTime;
	/// <summary>
	/// <p align="right" dir="rtl"><span dir="rtl">����� � ���� ������</span>
	/// </p><p align="right" dir="rtl"></p>
	/// </summary>
	public DateTime ExpiretionDateTime;
	/// <summary>
	/// <p align="right" dir="rtl"><span dir="rtl">����� � ���� ������</span>
	/// </p><p align="right" dir="rtl"></p>
	/// </summary>
	public DateTime PublishDateTime;
	/// <summary>
	/// <p align="right" dir="rtl"><span dir="rtl">����� � ���� ����� �����</span></p>
	/// </summary>
	public DateTime LastChangeDateTime;
	/// <summary>
	/// <p align="right" dir="rtl"><span dir="rtl">����� ����� ����� �����
	/// �����</span>
	/// </p><p align="right" dir="rtl"></p>
	/// </summary>
	public int LastChangeUserId;
	/// <summary>
	/// <p align="right" dir="rtl"><span dir="rtl">����� ����</span>
	/// </p><p align="right" dir="rtl"></p>
	/// </summary>
	public Enumerations.FolderStatusENUM FolderStatus;
	/// <summary>
	/// <p align="right" dir="rtl"><span dir="rtl">����� ����� ����</span>
	/// </p><p align="right" dir="rtl"></p>
	/// </summary>
	public int OrderID;
	/// <summary>
	/// <p align="right" dir="rtl"><span dir="rtl">����� ���</span>
	/// </p><p align="right" dir="rtl"></p>
	/// </summary>
	public int ParentID;
	/// <summary>
	/// <p align="right" dir="rtl"><span dir="rtl">����� � ���� �ǐ</span></p>
	/// </summary>
	public DateTime LogDateTime;
	/// <summary>
	/// <p align="right" dir="rtl"><span dir="rtl">��� ��ǘ��</span></p>
	/// </summary>
	public Enumerations.TransactionTypeENUM TransactionType;
	public User m_User;

	public FolderLog(){

	}

	~FolderLog(){

	}

}//end FolderLog