namespace MultiplayerARPG
{
    public enum UITextKeys : ushort
    {
        NONE,
        // UI Generic Title
        UI_LABEL_DISCONNECTED,
        UI_LABEL_SUCCESS,
        UI_LABEL_ERROR,
        UI_LABEL_NONE,
        UI_LABEL_MESSAGE,
        UI_LABEL_WARNING,
        // Error - Generic Error
        UI_ERROR_UNKNOW,
        UI_ERROR_BAD_REQUEST,
        UI_ERROR_NOT_ALLOWED,
        UI_ERROR_SERVICE_NOT_AVAILABLE,
        UI_ERROR_CONTENT_NOT_AVAILABLE,
        UI_ERROR_FEATURE_IS_DISABLED,
        UI_ERROR_REQUEST_TIMEOUT,
        UI_ERROR_KICKED_FROM_SERVER,
        UI_ERROR_CONNECTION_FAILED,
        UI_ERROR_CONNECTION_REJECTED,
        UI_ERROR_REMOTE_CONNECTION_CLOSE,
        UI_ERROR_INVALID_PROTOCOL,
        UI_ERROR_HOST_UNREACHABLE,
        UI_ERROR_CONNECTION_TIMEOUT,
        UI_ERROR_INTERNAL_SERVER_ERROR,
        UI_ERROR_SERVER_NOT_FOUND,
        UI_ERROR_USER_NOT_FOUND,
        UI_ERROR_CHARACTER_NOT_FOUND,
        UI_ERROR_ITEM_NOT_FOUND,
        UI_ERROR_CASH_PACKAGE_NOT_FOUND,
        UI_ERROR_NOT_ENOUGH_GOLD,
        UI_ERROR_NOT_ENOUGH_CASH,
        UI_ERROR_NOT_ENOUGH_ITEMS,
        UI_ERROR_NOT_ENOUGH_STAT_POINT,
        UI_ERROR_NOT_ENOUGH_SKILL_POINT,
        UI_ERROR_DISALLOW_SKILL_LEVEL_UP,
        UI_ERROR_NOT_LOGGED_IN,
        UI_ERROR_USERNAME_IS_EMPTY,
        UI_ERROR_PASSWORD_IS_EMPTY,
        UI_ERROR_WILL_OVERWHELMING,
        UI_ERROR_NOT_ABLE_TO_LOOT,
        // Error - Game Data
        UI_ERROR_INVALID_DATA,
        UI_ERROR_INVALID_CHARACTER_DATA,
        UI_ERROR_INVALID_CHARACTER_ENTITY,
        UI_ERROR_INVALID_ITEM_DATA,
        UI_ERROR_INVALID_ITEM_INDEX,
        UI_ERROR_INVALID_ENHANCER_ITEM_INDEX,
        UI_ERROR_ITEM_NOT_EQUIPMENT,
        UI_ERROR_INVALID_ATTRIBUTE_DATA,
        UI_ERROR_INVALID_CURRENCY_DATA,
        UI_ERROR_INVALID_SKILL_DATA,
        UI_ERROR_INVALID_GUILD_SKILL_DATA,
        UI_ERROR_INVALID_FACTION_DATA,
        UI_ERROR_INVALID_BUILDING_DATA,
        UI_ERROR_INVALID_BUILDING_ENTITY,
        UI_ERROR_INVALID_VEHICLE_ENTITY,
        // Error - Vehicle
        UI_ERROR_SEAT_NOT_AVAILABLE,
        // Error - UI Login
        UI_ERROR_INVALID_USERNAME_OR_PASSWORD,
        UI_ERROR_INVALID_USER_TOKEN,
        UI_ERROR_ALREADY_LOGGED_IN,
        UI_ERROR_ACCOUNT_LOGGED_IN_BY_OTHER,
        UI_ERROR_USER_BANNED,
        UI_ERROR_EMAIL_NOT_VERIFIED,
        // Error - UI Register
        UI_ERROR_INVALID_CONFIRM_PASSWORD,
        UI_ERROR_USERNAME_TOO_SHORT,
        UI_ERROR_USERNAME_TOO_LONG,
        UI_ERROR_PASSWORD_TOO_SHORT,
        UI_ERROR_INVALID_EMAIL,
        UI_ERROR_EMAIL_ALREADY_IN_USE,
        UI_ERROR_USERNAME_EXISTED,
        UI_ERROR_INVALID_USERNAME,
        // Error - UI Lobby
        UI_ERROR_ALREADY_CONNECTED_TO_LOBBY,
        UI_ERROR_ALREADY_CONNECTED_TO_GAME,
        UI_ERROR_NO_SELECTED_REALM,
        UI_ERROR_NO_AVAILABLE_REALM,
        UI_ERROR_NO_AVAILABLE_LOBBY,
        // Error - UI Character List
        UI_ERROR_NO_CHOSEN_CHARACTER_TO_START,
        UI_ERROR_NO_CHOSEN_CHARACTER_TO_DELETE,
        UI_ERROR_ALREADY_SELECT_CHARACTER,
        UI_ERROR_MAP_SERVER_NOT_READY,
        // Error - UI Character Create
        UI_ERROR_CHARACTER_NAME_TOO_SHORT,
        UI_ERROR_CHARACTER_NAME_TOO_LONG,
        UI_ERROR_CHARACTER_NAME_EXISTED,
        UI_ERROR_INVALID_CHARACTER_NAME,
        // Error - UI Cash Packages
        UI_ERROR_INVALID_IAP_RECEIPT,
        UI_ERROR_CANNOT_GET_CASH_PACKAGE_INFO,
        // Error - UI Cash Shop
        UI_ERROR_CANNOT_GET_CASH_SHOP_INFO,
        // Error - UI Guild Name
        UI_ERROR_GUILD_NAME_TOO_SHORT,
        UI_ERROR_GUILD_NAME_TOO_LONG,
        UI_ERROR_GUILD_NAME_EXISTED,
        UI_ERROR_INVALID_GUILD_NAME,
        // Error - UI Guild Role Setting
        UI_ERROR_GUILD_ROLE_NAME_TOO_SHORT,
        UI_ERROR_GUILD_ROLE_NAME_TOO_LONG,
        UI_ERROR_GUILD_ROLE_SHARE_EXP_NOT_NUMBER,
        // Error - UI Guild Member Role Setting
        UI_ERROR_INVALID_GUILD_ROLE,
        // Error - UI Guild Message Setting
        UI_ERROR_GUILD_MESSAGE_TOO_LONG,
        // Error - Equip
        UI_ERROR_CANNOT_EQUIP,
        UI_ERROR_INVALID_EQUIP_POSITION_RIGHT_HAND,
        UI_ERROR_INVALID_EQUIP_POSITION_LEFT_HAND,
        UI_ERROR_INVALID_EQUIP_POSITION_RIGHT_HAND_OR_LEFT_HAND,
        UI_ERROR_INVALID_EQUIP_POSITION_ARMOR,
        // Error - Refine
        UI_ERROR_CANNOT_REFINE,
        UI_ERROR_REFINE_ITEM_REACHED_MAX_LEVEL,
        UI_REFINE_SUCCESS,
        UI_REFINE_FAIL,
        // Enhance
        UI_ERROR_CANNOT_ENHANCE_SOCKET,
        UI_ERROR_NOT_ENOUGH_SOCKET_ENCHANER,
        UI_ERROR_NO_EMPTY_SOCKET,
        UI_ERROR_SOCKET_NOT_EMPTY,
        UI_ERROR_CANNOT_REMOVE_ENHANCER,
        UI_ERROR_NO_ENHANCER,
        // Repair
        UI_ERROR_CANNOT_REPAIR,
        UI_REPAIR_SUCCESS,
        // Dealing
        UI_ERROR_CHARACTER_IS_DEALING,
        UI_ERROR_CHARACTER_IS_TOO_FAR,
        UI_ERROR_CANNOT_ACCEPT_DEALING_REQUEST,
        UI_ERROR_DEALING_REQUEST_DECLINED,
        UI_ERROR_INVALID_DEALING_STATE,
        UI_ERROR_DEALING_CANCELED,
        UI_ERROR_ANOTHER_CHARACTER_WILL_OVERWHELMING,
        // Restriction
        UI_ERROR_ITEM_DEALING_RESTRICTED,
        UI_ERROR_ITEM_DROPPING_RESTRICTED,
        UI_ERROR_ITEM_SELLING_RESTRICTED,
        // Party
        UI_ERROR_PARTY_NOT_FOUND,
        UI_ERROR_PARTY_INVITATION_NOT_FOUND,
        UI_PARTY_INVITATION_ACCEPTED,
        UI_PARTY_INVITATION_DECLINED,
        UI_ERROR_CANNOT_SEND_PARTY_INVITATION,
        UI_ERROR_CANNOT_KICK_PARTY_MEMBER,
        UI_ERROR_CANNOT_KICK_YOURSELF_FROM_PARTY,
        UI_ERROR_CANNOT_KICK_PARTY_LEADER,
        UI_ERROR_JOINED_ANOTHER_PARTY,
        UI_ERROR_NOT_JOINED_PARTY,
        UI_ERROR_NOT_PARTY_LEADER,
        UI_ERROR_ALREADY_IS_PARTY_LEADER,
        UI_ERROR_CHARACTER_JOINED_ANOTHER_PARTY,
        UI_ERROR_CHARACTER_NOT_JOINED_PARTY,
        UI_ERROR_PARTY_MEMBER_REACHED_LIMIT,
        UI_ERROR_PARTY_MEMBER_CANNOT_ENTER_INSTANCE,
        // Guild
        UI_ERROR_GUILD_NOT_FOUND,
        UI_ERROR_GUILD_INVITATION_NOT_FOUND,
        UI_GUILD_INVITATION_ACCEPTED,
        UI_GUILD_INVITATION_DECLINED,
        UI_ERROR_CANNOT_SEND_GUILD_INVITATION,
        UI_ERROR_CANNOT_KICK_GUILD_MEMBER,
        UI_ERROR_CANNOT_KICK_YOURSELF_FROM_GUILD,
        UI_ERROR_CANNOT_KICK_GUILD_LEADER,
        UI_ERROR_CANNOT_KICK_HIGHER_GUILD_MEMBER,
        UI_ERROR_JOINED_ANOTHER_GUILD,
        UI_ERROR_NOT_JOINED_GUILD,
        UI_ERROR_NOT_GUILD_LEADER,
        UI_ERROR_ALREADY_IS_GUILD_LEADER,
        UI_ERROR_CANNOT_CHANGE_GUILD_LEADER_ROLE,
        UI_ERROR_CHARACTER_JOINED_ANOTHER_GUILD,
        UI_ERROR_CHARACTER_NOT_JOINED_GUILD,
        UI_ERROR_GUILD_MEMBER_REACHED_LIMIT,
        UI_ERROR_GUILD_ROLE_NOT_AVAILABLE,
        UI_ERROR_GUILD_SKILL_REACHED_MAX_LEVEL,
        UI_ERROR_NOT_ENOUGH_GUILD_SKILL_POINT,
        UI_ERROR_CANNOT_ACCEPT_GUILD_REQUEST,
        UI_ERROR_CANNOT_DECLINE_GUILD_REQUEST,
        // Game Data
        UI_UNKNOW_GAME_DATA_TITLE,
        UI_UNKNOW_GAME_DATA_DESCRIPTION,
        // Bank
        UI_ERROR_NOT_ENOUGH_GOLD_TO_DEPOSIT,
        UI_ERROR_NOT_ENOUGH_GOLD_TO_WITHDRAW,
        UI_ERROR_CANNOT_ACCESS_STORAGE,
        UI_ERROR_CANNOT_GET_STORAGE_ITEMS,
        UI_ERROR_CANNOT_UPDATE_STORAGE_ITEMS,
        UI_ERROR_OTHER_GUILD_MEMBER_ACCESSING_STORAGE,
        UI_ERROR_STORAGE_NOT_FOUND,
        // Combatant
        UI_ERROR_NO_AMMO,
        UI_ERROR_NOT_ENOUGH_HP,
        UI_ERROR_NOT_ENOUGH_MP,
        UI_ERROR_NOT_ENOUGH_STAMINA,
        UI_ERROR_NOT_DEAD,
        // Skills
        UI_ERROR_SKILL_LEVEL_IS_ZERO,
        UI_ERROR_CANNOT_USE_SKILL_WITHOUT_SHIELD,
        UI_ERROR_CANNOT_USE_SKILL_BY_CURRENT_WEAPON,
        UI_ERROR_CANNOT_USE_SKILL_BY_CURRENT_ARMOR,
        UI_ERROR_CANNOT_USE_SKILL_BY_CURRENT_VEHICLE,
        UI_ERROR_SKILL_IS_COOLING_DOWN,
        UI_ERROR_SKILL_IS_NOT_LEARNED,
        UI_ERROR_NO_SKILL_TARGET,
        // Items
        UI_ERROR_ITEM_IS_COOLING_DOWN,
        UI_ERROR_ITEM_IS_LOCKED,
        // Requirement
        UI_ERROR_NOT_ENOUGH_LEVEL,
        UI_ERROR_NOT_MATCH_CHARACTER_CLASS,
        UI_ERROR_NOT_MATCH_CHARACTER_FACTION,
        UI_ERROR_NOT_ENOUGH_ATTRIBUTE_AMOUNTS,
        UI_ERROR_NOT_ENOUGH_SKILL_LEVELS,
        UI_ERROR_NOT_ENOUGH_CURRENCY_AMOUNTS,
        UI_ERROR_ATTRIBUTE_REACHED_MAX_AMOUNT,
        UI_ERROR_SKILL_REACHED_MAX_LEVEL,
        // Success - UI Cash Shop
        UI_CASH_SHOP_ITEM_BOUGHT,
        // Success - UI Gacha
        UI_GACHA_OPENED,
        // UI Character Item
        UI_DROP_ITEM,
        UI_DROP_ITEM_DESCRIPTION,
        UI_DESTROY_ITEM,
        UI_DESTROY_ITEM_DESCRIPTION,
        UI_SELL_ITEM,
        UI_SELL_ITEM_DESCRIPTION,
        UI_DISMANTLE_ITEM,
        UI_DISMANTLE_ITEM_DESCRIPTION,
        UI_OFFER_ITEM,
        UI_OFFER_ITEM_DESCRIPTION,
        UI_PUT_VENDING_ITEM_AMOUNT,
        UI_PUT_VENDING_ITEM_AMOUNT_DESCRIPTION,
        UI_PUT_VENDING_ITEM_PRICE,
        UI_PUT_VENDING_ITEM_PRICE_DESCRIPTION,
        UI_MOVE_ITEM_TO_STORAGE,
        UI_MOVE_ITEM_TO_STORAGE_DESCRIPTION,
        UI_MOVE_ITEM_FROM_STORAGE,
        UI_MOVE_ITEM_FROM_STORAGE_DESCRIPTION,
        UI_MOVE_ITEM_FROM_ITEMS_CONTAINER,
        UI_MOVE_ITEM_FROM_ITEMS_CONTAINER_DESCRIPTION,
        UI_ERROR_STORAGE_WILL_OVERWHELMING,
        // UI Bank
        UI_BANK_DEPOSIT,
        UI_BANK_DEPOSIT_DESCRIPTION,
        UI_BANK_WITHDRAW,
        UI_BANK_WITHDRAW_DESCRIPTION,
        // UI Dealing
        UI_OFFER_GOLD,
        UI_OFFER_GOLD_DESCRIPTION,
        // UI Npc Sell Item
        UI_BUY_ITEM,
        UI_BUY_ITEM_DESCRIPTION,
        // UI Party
        UI_PARTY_CHANGE_LEADER,
        UI_PARTY_CHANGE_LEADER_DESCRIPTION,
        UI_PARTY_KICK_MEMBER,
        UI_PARTY_KICK_MEMBER_DESCRIPTION,
        UI_PARTY_LEAVE,
        UI_PARTY_LEAVE_DESCRIPTION,
        // UI Guild
        UI_GUILD_CHANGE_LEADER,
        UI_GUILD_CHANGE_LEADER_DESCRIPTION,
        UI_GUILD_KICK_MEMBER,
        UI_GUILD_KICK_MEMBER_DESCRIPTION,
        UI_GUILD_LEAVE,
        UI_GUILD_LEAVE_DESCRIPTION,
        UI_GUILD_REQUEST,
        UI_GUILD_REQUEST_DESCRIPTION,
        UI_GUILD_REQUESTED,
        UI_GUILD_REQUEST_ACCEPTED,
        UI_GUILD_REQUEST_DECLINED,
        // UI Guild Role
        UI_GUILD_ROLE_CAN_INVITE,
        UI_GUILD_ROLE_CANNOT_INVITE,
        UI_GUILD_ROLE_CAN_KICK,
        UI_GUILD_ROLE_CANNOT_KICK,
        UI_GUILD_ROLE_CAN_USE_STORAGE,
        UI_GUILD_ROLE_CANNOT_USE_STORAGE,
        // Friend
        UI_FRIEND_ADD,
        UI_FRIEND_ADD_DESCRIPTION,
        UI_FRIEND_REMOVE,
        UI_FRIEND_REMOVE_DESCRIPTION,
        UI_FRIEND_REQUEST,
        UI_FRIEND_REQUEST_DESCRIPTION,
        UI_FRIEND_ADDED,
        UI_FRIEND_REMOVED,
        UI_FRIEND_REQUESTED,
        UI_FRIEND_REQUEST_ACCEPTED,
        UI_FRIEND_REQUEST_DECLINED,
        // Item Amount Title
        UI_LABEL_UNLIMIT_WEIGHT,
        UI_LABEL_UNLIMIT_SLOT,
        // Enter Building Password
        UI_ENTER_BUILDING_PASSWORD,
        UI_ENTER_BUILDING_PASSWORD_DESCRIPTION,
        // Enter Building Password
        UI_SET_BUILDING_PASSWORD,
        UI_SET_BUILDING_PASSWORD_DESCRIPTION,
        // Building Error
        UI_ERROR_WRONG_BUILDING_PASSWORD,
        UI_ERROR_REACHED_BUILD_LIMIT,
        // IAP Error
        UI_ERROR_IAP_NOT_INITIALIZED,
        UI_ERROR_IAP_PURCHASING_UNAVAILABLE,
        UI_ERROR_IAP_EXISTING_PURCHASE_PENDING,
        UI_ERROR_IAP_PRODUCT_UNAVAILABLE,
        UI_ERROR_IAP_SIGNATURE_INVALID,
        UI_ERROR_IAP_USER_CANCELLED,
        UI_ERROR_IAP_PAYMENT_DECLINED,
        UI_ERROR_IAP_DUPLICATE_TRANSACTION,
        UI_ERROR_IAP_UNKNOW,
        // Mail
        UI_ERROR_MAIL_SEND_NOT_ALLOWED,
        UI_ERROR_MAIL_SEND_NO_RECEIVER,
        UI_MAIL_SENT,
        UI_ERROR_MAIL_READ_NOT_ALLOWED,
        UI_ERROR_MAIL_CLAIM_NOT_ALLOWED,
        UI_ERROR_MAIL_CLAIM_ALREADY_CLAIMED,
        UI_ERROR_MAIL_CLAIM_WILL_OVERWHELMING,
        UI_MAIL_CLAIMED,
        UI_ERROR_MAIL_DELETE_NOT_ALLOWED,
        UI_MAIL_DELETED,
        // Vending
        UI_START_VENDING,
        UI_START_VENDING_DESCRIPTION,
        UI_STOP_VENDING,
        UI_STOP_VENDING_DESCRIPTION,
        UI_ERROR_NO_START_VENDING_ITEMS,
        UI_ERROR_REACHED_VENDING_ITEMS_LIMIT,
        // Error - App Server
        UI_ERROR_APP_NOT_READY,
        UI_ERROR_MAP_EXISTED,
        UI_ERROR_EVENT_EXISTED,
        UI_ERROR_INVALID_SERVER_HASH,
        // Error - Map Spawn Server
        UI_ERROR_EMPTY_SCENE_NAME,
        UI_ERROR_CANNOT_EXCUTE_MAP_SERVER,
        // Enter Amount
        UI_ENTER_ITEM_AMOUNT,
        UI_ENTER_ITEM_AMOUNT_DESCRIPTION,
        // Error - Dueling
        UI_ERROR_CHARACTER_IS_DUELING,
        UI_ERROR_CANNOT_ACCEPT_DUELING_REQUEST,
        UI_ERROR_DUELING_REQUEST_DECLINED,
        // Error - Safe Zone
        UI_ERROR_CHARACTER_IS_IN_SAFE_AREA,
        // Error - Channels
        UI_ERROR_INVALID_CHANNEL_ID,
        UI_ERROR_CHANNEL_IS_FULL,
        // 1.86 Buff
        UI_LABEL_BUFF_DISALLOW_MOVE,
        UI_LABEL_BUFF_DISALLOW_SPRINT,
        UI_LABEL_BUFF_DISALLOW_WALK,
        UI_LABEL_BUFF_DISALLOW_JUMP,
        UI_LABEL_BUFF_DISALLOW_CROUCH,
        UI_LABEL_BUFF_DISALLOW_CRAWL,
        UI_LABEL_BUFF_DISALLOW_ATTACK,
        UI_LABEL_BUFF_DISALLOW_USE_SKILL,
        UI_LABEL_BUFF_DISALLOW_USE_ITEM,
        UI_LABEL_BUFF_FREEZE_ANIMATION,
        UI_LABEL_BUFF_IS_HIDE,
        UI_LABEL_BUFF_IS_REVEALS_HIDE,
        UI_LABEL_BUFF_IS_BLIND,
        UI_LABEL_BUFF_MUTE_FOOTSTEP_SOUND,
        UI_LABEL_BUFF_DO_NOT_REMOVE_ON_DEAD,
        UI_LABEL_BUFF_IS_EXTEND_DURATION,
        // 1.86d Items Limit Error
        UI_ERROR_REACHED_DEALING_ITEMS_LIMIT,
        UI_ERROR_REACHED_REFINE_ENHANCER_ITEMS_LIMIT,
        // 1.87 Buff
        UI_LABEL_BUFF_DISALLOW_DASH,
    }
}