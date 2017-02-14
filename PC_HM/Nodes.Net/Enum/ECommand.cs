﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Nodes.Net
{
    public enum ECommand : uint
    {
        None = 0x00000000,

        RequestLogin = 0x00000001,
        ResponseLogin = 0x10000001,
        RequestLogout = 0x00000002,
        ResponseLogout = 0x10000002,

        RequestNotify = 0x00000003,
        ResponseNotify = 0x10000003,

        P_ASN_CANCEL_VEHICLE = 10,
        P_ASN_CLOSE = 20,
        P_ASN_CLOSE_CHECK = 30,
        P_ASN_GET_BILL_CONTAINER_RECORDS = 40,
        P_ASN_GET_BILL_STATE = 50,
        P_ASN_GET_CHECK_STATE = 60,
        P_ASN_GET_CONTAINER_DETAIL = 70,
        P_ASN_GET_PUTAWAY_DATA = 80,
        P_ASN_GET_REC_LOC = 90,
        P_ASN_GET_REC_LOC_BY_SKU = 100,
        P_ASN_OPEN_CNNTAINER = 110,
        P_ASN_OVERSTOCK_SAVE = 120,
        P_ASN_SAVE_CONTAINER = 130,
        P_ASN_SAVE_CONTAINER_STATE = 140,
        P_ASN_SAVE_NO_BILL_INSTORE = 150,
        P_ASN_SAVE_PUTAWAY = 160,
        P_ASN_SAVE_PUTAWAY_COMPLETE = 170,
        P_ASN_SAVE_PUTAWAY_NO_TASK = 180,
        P_ASN_SAVE_VEHICLE = 190,
        P_ASN_TEST = 200,
        P_ASN_UPDATE_STATE = 210,

        P_CBN_SAVE_DETAIL = 220,
        P_CBN_SAVE_HEADER = 230,

        P_COMMON_CHECK_CONTAINER = 240,

        P_COUNT_CLOSE_LOCATION = 250,
        P_COUNT_COPLETE = 260,
        P_COUNT_REPORT = 270,
        P_COUNT_SAVE_RECORD = 280,
        P_COUNT_STOCK = 290,

        P_CRN_SAVE_CONTAINER_STATE = 300,
        P_CRN_SAVE_DETAIL = 310,
        P_CRN_SAVE_HEADER = 320,
        P_CRN_SAVE_PUTAWAY = 330,
        P_CRN_UPDATE_DETAIL = 340,

        P_GET_CONTAINER_CAGE = 350,
        
        P_REPLENISH_BY_SKU = 360,
        P_REPLENISH_CALC = 370,
        P_REPLENISH_INQUIRY = 380,
        P_REPLENISH_SAVE = 390,

        P_SAVE_TASK_COMPLETE = 400,

        P_SO_ADD_CONTAINER_INTERFACE = 410,
        P_SO_AUTO_TASK = 420,
        P_SO_AUTO_TASK_CREATE = 430,
        P_SO_BEFORE_SAVE_PICK = 440,
        P_SO_BILL_GROUP = 450,
        P_SO_CANCEL_BILL = 460,
        P_SO_CHANGE_PICK_TYPE = 470,
        P_SO_CHECK_PICK_RESULT = 480,
        P_SO_CLOSE_BILL = 490,
        P_SO_CLOSE_BILL_INTERFACE = 500,
        P_SO_CLOSE_PICK_INTERFACE = 510,
        P_SO_CLOSE_PICK_TASK = 520,
        P_SO_CLOSE_PICK_TASK_HAND = 530,
        P_SO_CLOSE_TASK = 540,
        P_SO_CONTAINER_JOIN_BILL = 550,
        P_SO_CONTAINER_MOVE = 560,
        P_SO_CONTAINER_WEIGHT = 570,
        P_SO_CONTAINER_WEIGHT_LOADING = 580,
        P_SO_CREATE_PICK_PLAN = 590,
        P_SO_CROSS_DOCK = 600,
        P_SO_CUT_STOCK = 610,
        P_SO_DELETE_PICK_PLAN = 620,
        P_SO_PRINT = 630,
        P_SO_SAVE_ORDER = 640,
        P_SO_SAVE_PICK_CASE_RECORD = 650,
        P_SO_SAVE_PICK_PLAN = 660,
        P_SO_SAVE_PICK_RECORD = 670,
        P_SO_SET_BILL_STATE = 680,
        P_SO_TO_VEHICLE = 690,

        P_STK_LOG = 700,
        P_STK_LOG_BY_SKU = 710,
        
        P_SYNC_CTWMS_SO_DETAIL = 720,
        P_SYNC_DATA_CUSTOM = 730,
        P_SYNC_DATA_CUSTOMER_ADDRESS = 740,
        P_SYNC_WMS_AREA = 750,
        P_SYNC_WMS_ASN_DETAIL = 760,
        P_SYNC_WMS_ASN_HEADER = 770,
        P_SYNC_WMS_BRAND_SUPPLIER = 780,
        P_SYNC_WMS_BRANDS = 790,
        P_SYNC_WMS_COMPANY = 800,
        P_SYNC_WMS_CONTAINER = 810,
        P_SYNC_WMS_CONTAINER_STATE = 820,
        P_SYNC_WMS_CUSTOMER_ADDRESS = 830,
        P_SYNC_WMS_CUSTOMER_LINE = 840,
        P_SYNC_WMS_CUSTOMERS = 850,
        P_SYNC_WMS_MODULE_ROLE = 860,
        P_SYNC_WMS_MODULES = 870,
        P_SYNC_WMS_ORGANIZATIONS = 880,
        P_SYNC_WMS_ROLES = 890,
        P_SYNC_WMS_ROUTE = 900,
        P_SYNC_WMS_SKU = 910,
        P_SYNC_WMS_SKU_WAREHOUSE = 920,
        P_SYNC_WMS_SO_DETAIL = 930,
        P_SYNC_WMS_SO_DETAILNUM = 940,
        P_SYNC_WMS_SO_HEADER = 950,
        P_SYNC_WMS_SUPPLIERS = 960,
        P_SYNC_WMS_UM = 970,
        P_SYNC_WMS_UM_SKU = 980,
        P_SYNC_WMS_USER_ONLINE = 990,
        P_SYNC_WMS_USER_ROLE = 1000,
        P_SYNC_WMS_USERS = 1010,
        P_SYNC_WMS_WAREHOUSE = 1020,

        P_SYS_LOGIN_REGISTER = 1030,

        P_TASK_CLOSE_PUTAWAY = 1040,
        P_TASK_CLOSE_REPLENISH = 1050,
        P_TASK_CYCLE_COUNT = 1060,
        P_TASK_FILL = 1070,
        P_TASK_GET_DETAIL = 1080,
        P_TASK_GET_STATE = 1090,
        P_TASK_PICK = 1100,
        P_TASK_PUTAWAY = 1110,
        P_TASK_SCHEDULE = 1120,

        P_TRANS_SAVE = 1130,
        P_TRANSFER_CHECK = 1140,

        P_WMS_WMSX_ASN_DETAIL = 1150,
        P_WMS_WMSX_ASN_HEADER = 1160,
        P_WMS_WMSX_CONTAINER_STATE = 1170,
        P_WMS_WMSX_CRN_DETAIL = 1180,
        P_WMS_WMSX_CRN_HEADER = 1190,
        P_WMS_WMSX_CUSTOMER = 1200,
        P_WMS_WMSX_SKU = 1210,
        P_WMS_WMSX_SKU_BARCODE = 1220,
        P_WMS_WMSX_SKU_WAREHOUSE = 1230,
        P_WMS_WMSX_SO_DETAIL = 1240,
        P_WMS_WMSX_SO_DETAIL_ATTRIBUTE = 1250,
        P_WMS_WMSX_SO_HEADER = 1260,
        P_WMS_WMSX_UM = 1270,
        P_WMS_WMSX_UM_SKU = 1280,
        P_WMS_WMSX_WAREHOUSE = 1290,

        P_WMSX_WMS_CRN_DETAIL = 1300,
        P_WMSX_WMS_CRN_HEADER = 1310,
    }
}
