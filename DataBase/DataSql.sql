INSERT INTO [SysModule] ([Id],[Name],[EnglishName],[ParentId],[Url],[Iconic],[Sort],[Remark],[State],[CreatePerson],[CreateTime],[IsLast],[Version]) values ('0','�����˵�','Root','0','','',0,'',1,'Administrator','10  1 2012 12:00AM',0,NULL);
INSERT INTO [SysModule] ([Id],[Name],[EnglishName],[ParentId],[Url],[Iconic],[Sort],[Remark],[State],[CreatePerson],[CreateTime],[IsLast],[Version]) values ('BaseSample','ģ������','Sample by Ajax','SampleFile','SysSample','',0,'',1,'Administrator',NULL,1,NULL);
INSERT INTO [SysModule] ([Id],[Name],[EnglishName],[ParentId],[Url],[Iconic],[Sort],[Remark],[State],[CreatePerson],[CreateTime],[IsLast],[Version]) values ('Document','�ҵ�����','Start','PersonDocument','Home/Doc','',0,'',1,'Administrator','10  1 2012 12:00AM',1,NULL);
INSERT INTO [SysModule] ([Id],[Name],[EnglishName],[ParentId],[Url],[Iconic],[Sort],[Remark],[State],[CreatePerson],[CreateTime],[IsLast],[Version]) values ('Info','�ҵ�����','Info','PersonDocument','Home/Info','',0,'',1,'Administrator','10  1 2012 12:00AM',1,NULL);
INSERT INTO [SysModule] ([Id],[Name],[EnglishName],[ParentId],[Url],[Iconic],[Sort],[Remark],[State],[CreatePerson],[CreateTime],[IsLast],[Version]) values ('InfoHome','��ҳ','Home','Information','MIS/Article','',1,'',1,'Administrator','10  1 2012 12:00AM',1,NULL);
INSERT INTO [SysModule] ([Id],[Name],[EnglishName],[ParentId],[Url],[Iconic],[Sort],[Remark],[State],[CreatePerson],[CreateTime],[IsLast],[Version]) values ('Information','��Ϣ����','Information','OA','','',0,'',1,'Administrator','10  1 2012 12:00AM',0,NULL);
INSERT INTO [SysModule] ([Id],[Name],[EnglishName],[ParentId],[Url],[Iconic],[Sort],[Remark],[State],[CreatePerson],[CreateTime],[IsLast],[Version]) values ('ManageInfo','��������','Manage Article','Information','MIS/ManageArticle','',4,'',1,'Administrator','10  1 2012 12:00AM',1,NULL);
INSERT INTO [SysModule] ([Id],[Name],[EnglishName],[ParentId],[Url],[Iconic],[Sort],[Remark],[State],[CreatePerson],[CreateTime],[IsLast],[Version]) values ('ModuleSetting','ģ��ά��','Module Setting','RightManage','SysModule','',100,'',1,'Administrator','10  1 2012 12:00AM',1,NULL);
INSERT INTO [SysModule] ([Id],[Name],[EnglishName],[ParentId],[Url],[Iconic],[Sort],[Remark],[State],[CreatePerson],[CreateTime],[IsLast],[Version]) values ('MyInfo','�ҵ���Ϣ','My Article','Information','MIS/MyArticle','',2,'',1,'Administrator','10  1 2012 12:00AM',1,NULL);
INSERT INTO [SysModule] ([Id],[Name],[EnglishName],[ParentId],[Url],[Iconic],[Sort],[Remark],[State],[CreatePerson],[CreateTime],[IsLast],[Version]) values ('PersonDocument','��������','Person Center','0','','',2,'',1,'Administrator','10  1 2012 12:00AM',0,NULL);
INSERT INTO [SysModule] ([Id],[Name],[EnglishName],[ParentId],[Url],[Iconic],[Sort],[Remark],[State],[CreatePerson],[CreateTime],[IsLast],[Version]) values ('RightManage','Ȩ�޹���','Authorities Management','0','','',4,'',1,'Administrator','10  1 2012 12:00AM',0,NULL);
INSERT INTO [SysModule] ([Id],[Name],[EnglishName],[ParentId],[Url],[Iconic],[Sort],[Remark],[State],[CreatePerson],[CreateTime],[IsLast],[Version]) values ('RoleAuthorize','��ɫȨ������','Role Authorize','RightManage','SysRight','',6,'',1,'Administrator','10  1 2012 12:00AM',1,NULL);
INSERT INTO [SysModule] ([Id],[Name],[EnglishName],[ParentId],[Url],[Iconic],[Sort],[Remark],[State],[CreatePerson],[CreateTime],[IsLast],[Version]) values ('RoleManage','��ɫ����','Role Manage','RightManage','SysRole','',2,'',1,'Administrator','10  1 2012 12:00AM',1,NULL);
INSERT INTO [SysModule] ([Id],[Name],[EnglishName],[ParentId],[Url],[Iconic],[Sort],[Remark],[State],[CreatePerson],[CreateTime],[IsLast],[Version]) values ('SampleFile','����ָ������','SampleFile','0','SysSample','',1,'',1,'Administrator',NULL,0,NULL);
INSERT INTO [SysModule] ([Id],[Name],[EnglishName],[ParentId],[Url],[Iconic],[Sort],[Remark],[State],[CreatePerson],[CreateTime],[IsLast],[Version]) values ('SystemConfig','ϵͳ����','System Config','SystemManage','SysConfig','',0,'',1,'Administrator','10  1 2012 12:00AM',1,NULL);
INSERT INTO [SysModule] ([Id],[Name],[EnglishName],[ParentId],[Url],[Iconic],[Sort],[Remark],[State],[CreatePerson],[CreateTime],[IsLast],[Version]) values ('SystemExcepiton','ϵͳ�쳣','System Exception','SystemManage','SysException','',2,'',1,'Administrator','10  1 2012 12:00AM',1,NULL);
INSERT INTO [SysModule] ([Id],[Name],[EnglishName],[ParentId],[Url],[Iconic],[Sort],[Remark],[State],[CreatePerson],[CreateTime],[IsLast],[Version]) values ('SystemJobs','ϵͳ����','System Jobs','TaskScheduling','Jobs/Jobs','',0,'',1,'Administrator','10  1 2012 12:00AM',1,NULL);
INSERT INTO [SysModule] ([Id],[Name],[EnglishName],[ParentId],[Url],[Iconic],[Sort],[Remark],[State],[CreatePerson],[CreateTime],[IsLast],[Version]) values ('SystemLog','ϵͳ��־','System Log','SystemManage','SysLog','',1,'',1,'Administrator','10  1 2012 12:00AM',1,NULL);
INSERT INTO [SysModule] ([Id],[Name],[EnglishName],[ParentId],[Url],[Iconic],[Sort],[Remark],[State],[CreatePerson],[CreateTime],[IsLast],[Version]) values ('SystemManage','ϵͳ����','System Management','0','','',3,'',1,'Administrator','10  1 2012 12:00AM',0,NULL);
INSERT INTO [SysModule] ([Id],[Name],[EnglishName],[ParentId],[Url],[Iconic],[Sort],[Remark],[State],[CreatePerson],[CreateTime],[IsLast],[Version]) values ('UserManage','ϵͳ����Ա','User Manage','RightManage','SysUser',NULL,1,NULL,1,'Administrator','10  1 2012 12:00AM',1,NULL);

INSERT INTO [SysModuleOperate] ([Id],[Name],[KeyCode],[ModuleId],[IsValid],[Sort]) values ('BaseSampleCreate','����','Create','BaseSample',0,0);
INSERT INTO [SysModuleOperate] ([Id],[Name],[KeyCode],[ModuleId],[IsValid],[Sort]) values ('BaseSampleDelete','ɾ��','Delete','BaseSample',0,0);
INSERT INTO [SysModuleOperate] ([Id],[Name],[KeyCode],[ModuleId],[IsValid],[Sort]) values ('BaseSampleDetails','��ϸ','Details','BaseSample',0,0);
INSERT INTO [SysModuleOperate] ([Id],[Name],[KeyCode],[ModuleId],[IsValid],[Sort]) values ('BaseSampleEdit','�༭','Edit','BaseSample',0,0);
INSERT INTO [SysModuleOperate] ([Id],[Name],[KeyCode],[ModuleId],[IsValid],[Sort]) values ('BaseSampleExport','����','Export','BaseSample',0,0);
INSERT INTO [SysModuleOperate] ([Id],[Name],[KeyCode],[ModuleId],[IsValid],[Sort]) values ('BaseSampleQuery','��ѯ','Query','BaseSample',0,0);
INSERT INTO [SysModuleOperate] ([Id],[Name],[KeyCode],[ModuleId],[IsValid],[Sort]) values ('BaseSampleSave','����','Save','BaseSample',0,0);

INSERT INTO [SysRole] ([Id],[Name],[Description],[CreateTime],[CreatePerson]) values ('administrator','��������Ա','ȫ����Ȩ','10  1 2012 12:00AM','Administrator');

INSERT INTO [SysRight] ([Id],[ModuleId],[RoleId],[Rightflag]) values ('administratorSampleFile','SampleFile','administrator',1);
INSERT INTO [SysRight] ([Id],[ModuleId],[RoleId],[Rightflag]) values ('administratorBaseSample','BaseSample','administrator',1);

INSERT INTO [SysRightOperate] ([Id],[RightId],[KeyCode],[IsValid]) values ('administratorBaseSampleCreate','administratorBaseSample','Create',1);
INSERT INTO [SysRightOperate] ([Id],[RightId],[KeyCode],[IsValid]) values ('administratorBaseSampleDelete','administratorBaseSample','Delete',1);
INSERT INTO [SysRightOperate] ([Id],[RightId],[KeyCode],[IsValid]) values ('administratorBaseSampleDetails','administratorBaseSample','Details',1);
INSERT INTO [SysRightOperate] ([Id],[RightId],[KeyCode],[IsValid]) values ('administratorBaseSampleEdit','administratorBaseSample','Edit',1);
INSERT INTO [SysRightOperate] ([Id],[RightId],[KeyCode],[IsValid]) values ('administratorBaseSampleExport','administratorBaseSample','Export',1);
INSERT INTO [SysRightOperate] ([Id],[RightId],[KeyCode],[IsValid]) values ('administratorBaseSampleQuery','administratorBaseSample','Query',1);
INSERT INTO [SysRightOperate] ([Id],[RightId],[KeyCode],[IsValid]) values ('administratorBaseSampleSave','administratorBaseSample','Save',1);

INSERT INTO [SysUser] ([Id],[UserName],[Password],[TrueName],[Card],[MobileNumber],[PhoneNumber],[QQ],[EmailAddress],[OtherContact],[Province],[City],[Village],[Address],[State],[CreateTime],[CreatePerson],[Sex],[Birthday],[JoinDate],[Marital],[Political],[Nationality],[Native],[School],[Professional],[Degree],[DepId],[PosId],[Expertise],[JobState],[Photo],[Attach]) 
values ('admin','admin','01-92-02-3A-7B-BD-73-25-05-16-F0-69-DF-18-B5-00','ϵͳ����Ա',NULL,NULL,'06638888888','324345345','ymnets@sina.com','MSN��ymnets','440000','440100','440101','СС����',1,'11 18 2012  3:40PM','admin','��','05 18 1900 12:00AM','01  1 2013 12:00AM','δ��','�й�','�й�','�㶫����','���������ѧ','���������','˶ʿ','20000','20001','������ѧ,Ϊ������,��������','��ְ',NULL,NULL);

INSERT INTO [SysRoleSysUser] ([SysUserId],[SysRoleId]) values ('admin','administrator');