create table idinfo
(
    id INT primary key IDENTITY(1,1),
    startid bigint,--起始ID
    maxid bigint,--当前最大ID
    biztype int,--业务类型
    setp int,--步长
    delta int DEFAULT(1),--每次增量
    creattime datetime ,--创建时间
    updatetime datetime,--更新时间
    version bigint DEFAULT(0) --版本号
    
)