'use strict';

import React, { Component } from 'react';
import { StyleSheet, TouchableOpacity, Text, DrawerLayoutAndroid, ListView, View,
    ToolbarAndroid, Image } from 'react-native';

const styles = StyleSheet.create({
  container: {
    flex: 1,
    justifyContent: 'center',
    backgroundColor: '#E3F2FD',
  },toolbar: {
    backgroundColor: '#FFF',
    height: 55,
    elevation: 5
  },box: {
    marginBottom: 10,
    backgroundColor: "#ffffff",
    shadowColor: "#000000",
    shadowOpacity: 0.8,
    shadowRadius: 2,
    shadowOffset: {
      height: 1,
      width: 0
    }
  },
  headerContainer: {
      flex: 1,
      margin: 2,
      flexDirection: 'row',
      justifyContent: 'space-between',
  },
  stageView: {
      margin: 3,
      width: 40,
      height: 20,
      borderWidth: 1,
  },buttonOn: {
    backgroundColor: '#2196F3',
    justifyContent: 'center',
    alignItems: 'center',
    borderWidth: 1,
    borderColor: '#2196F3'
  },buttonOff: {
    backgroundColor: '#FFF',
    justifyContent: 'center',
    alignItems: 'center',
    borderWidth: 1,
    borderColor: '#2196F3'
  }
});

var dataSource = new ListView.DataSource({rowHasChanged: (r1, r2) => r1.guid !== r2.guid});

class List extends Component {
   constructor(props) {
    super(props);
    this.state = {};
  }

  renderHeader(){
    return(<View style={{flexDirection: 'row', justifyContent: 'center', margin: 5}}>
                <TouchableOpacity style={[styles.buttonOn, {width: 120, height: 35}]} onPress={() => {}}>
                    <Text style={{color: '#FFF', textAlign: 'center'}}>Активные</Text>
                </TouchableOpacity>
                <TouchableOpacity style={[styles.buttonOff, {width: 120, height: 35}]} onPress={() => {}}>
                    <Text style={{color: '#2196F3', textAlign: 'center'}}>Не активные</Text>
                </TouchableOpacity>
            </View>)
  }

  renderRow(rowData, sectionID, rowID) {
    return (
        <View style={styles.box}>
            <View style={styles.headerContainer}>
                <Text style={{fontSize: 15, fontWeight: 'bold',}}>Соглосование № 76</Text>
                <Text>22.07.16 17:45</Text>
            </View>
            <View style={{height: 2, backgroundColor: '#E0E0E0'}}/>
            <View style={{flexDirection: 'row'}}>
                <Titels/>
                <View style={{flex: 3, padding: 5, flexDirection: 'column', alignItems: 'flex-start',}}>
                    <Text>Text</Text>
                    <Text>Text</Text>
                    <Text>Text</Text>
                    <Text>Text</Text>
                    <Text>Text</Text>
                    <AgreementStage/>
                </View>
                <View style={{flex: 1, flexDirection: 'row', justifyContent: 'flex-end',}}>
                    <TouchableOpacity onPress={() => {this.props.navigator.push({title: "Info"});}}>
                        <Image source={require('./img/info-button.png')} 
                                style={{width: 20, height: 20, margin: 5}}/>
                    </TouchableOpacity>
                </View>
            </View>
        </View>
    );
  }

  navigationView()
    {return(
        <View style={{flex: 1, backgroundColor: '#E3F2FD', paddingTop: 50}}>
            <View style={{flex : 1,}}>                   
                <View style={{flexDirection: 'row', margin: 5, height: 35}}>
                    <TouchableOpacity style={[styles.buttonOff, {flex: 2}]}>
                        <Text style={{color: '#2196F3', textAlign: 'center', fontSize: 12}}>Все</Text>
                    </TouchableOpacity>
                    <TouchableOpacity style={[styles.buttonOn, {flex: 2}]}>
                        <Text style={{color: '#FFF', textAlign: 'center', fontSize: 12}}>Я автор</Text>
                    </TouchableOpacity>
                    <TouchableOpacity style={[styles.buttonOff, {flex: 3}]}>
                        <Text style={{color: '#2196F3', textAlign: 'center', fontSize: 12}}>Моё подразделение</Text>
                    </TouchableOpacity>
                </View>
                <TouchableOpacity style={[styles.buttonOff, {width: 200, height: 35}]}>
                    <Text style={{color: '#2196F3', textAlign: 'center', fontSize: 12}}>Я согласующее лицо</Text>
                </TouchableOpacity>
                <View style={{margin: 5, height: 2, backgroundColor: '#E0E0E0'}}/>
                <TouchableOpacity style={[styles.buttonOff, {width: 200, height: 35}]}>
                    <Text style={{color: '#2196F3', textAlign: 'center', fontSize: 12}}>Сбросить значения</Text>
                </TouchableOpacity>
            </View>
        </View>
    );}
  
  render() {
    return (
        <DrawerLayoutAndroid
            drawerWidth={300}
            ref="drawerMenu"
            drawerPosition={DrawerLayoutAndroid.positions.Left}
            renderNavigationView={this.navigationView.bind(this)}>
            <View style={styles.container}>
                <ToolbarAndroid
                    style={styles.toolbar}
                    title="Список согласований"
                    navIcon={require('./img/menu.png')}
                    onIconClicked={() => {this.refs.drawerMenu.openDrawer()}} />
                <ListView visible={false} dataSource={dataSource.cloneWithRows([1, 2, 3])} 
                    renderHeader={this.renderHeader.bind(this)}
                    renderRow={this.renderRow.bind(this)}/>
            </View>
        </DrawerLayoutAndroid>
    );
  }
}

class Titels extends Component{
  render(){return(
    <View style={{flex: 2,
      padding: 5,
        flexDirection: 'column',
        alignItems: 'flex-end',}}>
      <Text>Тип документа:</Text>
      <Text>Должность:</Text>
      <Text>Подразделение:</Text>
      <Text>Статус:</Text>
    </View>
  );}
}

class AgreementStage extends Component{
  render(){return(
    <View style={{flex: 1,
        flexDirection: 'row',
        justifyContent: 'flex-start',}}>
        <View style={[styles.stageView, {backgroundColor: '#3c763d'}]} />
        <View style={[styles.stageView, {backgroundColor: '#3c763d'}]} />
        <View style={[styles.stageView, {backgroundColor: '#c9302c'}]} />
        <View style={[styles.stageView, {backgroundColor: '#e3c800'}]} />
        <View style={[styles.stageView, {backgroundColor: '#FFF'}]} />
    </View>
  );}
}

module.exports = List;