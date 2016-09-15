'use strict';

import React, { Component } from 'react';
import { Image, StyleSheet, TouchableOpacity, Text, View, ScrollView, ListView, ToolbarAndroid
   } from 'react-native';

var dataSource = new ListView.DataSource({rowHasChanged: (r1, r2) => r1.guid !== r2.guid});

const styles = StyleSheet.create({
  toolbar: {
    backgroundColor: '#FFF',
    height: 55,
    elevation: 5
  },button: {
      margin: 5,
      height: 40,
      justifyContent: 'center',
      alignItems: 'center',
  }
});

class Info extends Component {
   constructor(props) {
    super(props);
    this.state = {comment: 'Test Text, Test Text, Test Text, Test Text, Test Text, Test Text, Test Text, Test Text, Test Text, '};
  }

  historyRenderRow(rowData, sectionID, rowID) {
    return (
        <View style={{backgroundColor: 'white',marginBottom: 5, padding: 5}}>
            <Text style={{fontSize: 15, fontWeight: 'bold',}}>Согласовано</Text>
            <Text >Дата и кем согласовано</Text>
            <Text>
                {((this.state.comment).length > 30) ? (((this.state.comment).substring(0,30-3)) + '...') : this.state.comment }
            </Text>
            <Text>
                {((this.state.comment).length > 30) ? ('читать полностью') : null }
            </Text>
            <Image source={require('./img/pdf.png')} style={{width: 30, height: 30}}/>      
        </View>
    );
  }

  renderRow(rowData, sectionID, rowID) {
    return (
        <View style={{backgroundColor: rowData, borderWidth: 1, padding: 5,}}>
            <Text style={{fontSize: 16, margin: 5}}>Кто-то</Text>
            <MainDataCard title={'Статус:'} data={'какой-то статус'}/>
            <MainDataCard title={'Изменено:'} data={'-'}/>
            <MainDataCard title={'Комментарий:'} data={'-'}/>
        </View>
    );
  }
  
  render() {
    return (
      <View style={{flex: 1}}>
      <ToolbarAndroid
                    style={styles.toolbar}
                    title="Согласование # 76"
                    navIcon={require('./img/test2.png')}
                    onIconClicked={() => {this.props.navigator.pop()}} />
      <ScrollView style={{flex: 1, backgroundColor: '#E3F2FD',}}>
          <View style={{flexDirection: 'column', justifyContent: 'center', margin: 5}}>
            <MainData title={'Тип документа:'} data={'Тип'}/>
            <MainData title={'Филиал:'} data={'Екатеринбург'}/>
            <MainData title={'Департамент:'} data={'Департ'}/>
            <MainData title={'Должность:'} data={'Герой'}/>
            <MainData title={'Руководитель:'} data={'Рехов А.'}/>
            <MainData title={'Руководитель принимающий решения:'} data={'Рехов А.'}/>
            <MainData title={'Автор заявки:'} data={'Трефилов А.'}/>
            <MainData title={'Причина возникновения:'} data={'Прост'}/>
          </View>
          <View style={{flexDirection: 'row', justifyContent: 'center', borderWidth: 1,}}>
            <Text style={{flex: 1, textAlign: 'right', margin: 3, fontSize: 16}}>Статус согласования:</Text>
            <Text style={{flex: 1, margin: 3, fontSize: 16}}>На рассмотрении</Text>
          </View>
          <View style={{marginTop: 10}}>
            <Text style={{fontSize: 16, fontWeight: 'bold',}}>История</Text>
            <View style={{height: 2, backgroundColor: '#E0E0E0'}}/>
            <ListView
                dataSource={dataSource.cloneWithRows([1, 1, 1, 1])}
                renderRow={this.historyRenderRow.bind(this)}/>
          </View>
          <TouchableOpacity style={[{backgroundColor: '#64DD17',}, styles.button]}>
            <Text style={{color: 'white'}}>Согласовать</Text>
          </TouchableOpacity>
          <TouchableOpacity style={[{backgroundColor: '#F44336'}, styles.button]}>
            <Text style={{color: 'white'}}>Отклонить</Text>
          </TouchableOpacity>
          <Text style={{fontSize: 16, fontWeight: 'bold', margin: 5}}>Лист согласований</Text>
            <ListView scrollEnabled={true}
            dataSource={dataSource.cloneWithRows(['#dff0d8', '#fff9c4', '#f2dede', '#e4e4e4'])}
            renderRow={this.renderRow.bind(this)}/>
        </ScrollView>
        </View>
    );
  }
}

class MainData extends Component{
  render(){return(
    <View style={{flexDirection: 'row', justifyContent: 'center',}}>
      <Text style={{flex: 1, fontWeight: 'bold', textAlign: 'right', margin: 3}}>{this.props.title}</Text>
      <Text style={{flex: 1, margin: 3}}>{this.props.data}</Text>
    </View>
  );}
}

class MainDataCard extends Component{
  render(){return(
    <View style={{flexDirection: 'row', justifyContent: 'center',}}>
      <Text style={{flex: 1, fontWeight: 'bold', textAlign: 'right', margin: 3}}>{this.props.title}</Text>
      <Text style={{flex: 1, margin: 3}}>{this.props.data}</Text>
    </View>
  );}
}

module.exports = Info;