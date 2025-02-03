mergeInto(LibraryManager.library, {
    SaveExtern: function(date){
        var dateString = UTF8ToString(date);
        var myobj = JSON.parse(dateString);
        player.setData(myobj);
    },

LoadExtern:function(){
    YaGames.init().then(ysdk => {
    player.getData().then(_date => {
        const myJSON = JSON.stringify(_date);
        myGameInstance.SendMessage('Progress', 'SetPlayerInfo', myJSON);
    });
    }).catch(err => {
        // Ошибка при инициализации ysdk.
    });},

GRAready:function(){
    YaGames.init()
    .then((ysdk) => {
        // Сообщаем платформе, что игра загрузилась и можно начинать играть.
        ysdk.features.LoadingAPI.ready()
    })
    .catch(console.error);
},
/*GRAstart:function(){
YaGames.init()
    .then((ysdk) => {
        ysdk.features.GameplayAPI.start()
        
    });
},
GRAstop:function(){
YaGames.init()
    .then((ysdk) => {
        ysdk.features.GameplayAPI.stop()
        
    });
},*/


    ShowAdv : function(){
        ysdk.adv.showFullscreenAdv({
    callbacks: {
        onClose: function(wasShown) {
          // Действие после закрытия рекламы.
        },
        onError: function(error) {
          // Действие в случае ошибки.
        }
    }
})
    }
}) 