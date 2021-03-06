﻿Ext.define("Facebook.store.FacebookVideoStore",
{
    extend: "Ext.data.Store",
    model: "Facebook.model.FacebookVideoModel",
    remoteSort: true,
    sorters: [
        {
            property: "Name",
            direction: "ASC"
        }
    ],
    pageSize: 15,
    autoLoad: true,
    autoSync: true,
    storeId: "FacebookVideoStoreId",
    proxy:
    {
        type: "ajax",
        timeout: 100000,
        headers:
        {
            'Content-Type': "application/json; charset=UTF-8"
        },
        reader:
        {
            root: "data",
            type: "json",
            totalProperty: "totalCount"
        },
        api:
        {
            read: "/Facebook/GetAllFacebookVideosAsync"
        },
        actionMethods:
        {
            read: "GET"
        }
    }
});