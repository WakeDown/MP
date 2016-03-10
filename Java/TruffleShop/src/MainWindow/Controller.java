package MainWindow;

import MainWindow.DataClasses.Product;

import javafx.collections.FXCollections;
import javafx.collections.ObservableList;
import javafx.fxml.FXML;
import javafx.scene.control.*;
import javafx.scene.control.Label;
import javafx.stage.FileChooser;

import javax.xml.bind.JAXBContext;
import javax.xml.bind.Marshaller;
import javax.xml.bind.Unmarshaller;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlRootElement;

import java.io.File;
import java.util.List;
import java.util.Optional;
import java.util.prefs.Preferences;

public class Controller {


    @FXML
    private static TableView<Product> tableData;

    @FXML
    private TableColumn<Product, String> nameProductColumn;

    @FXML
    private Label nameProd, quantityOfProd, startPriseProd, endPriseProd, salesProd;

    private static ObservableList<Product> data = FXCollections.observableArrayList(new Product("Мастика"));

    public static ObservableList<Product> getData() {
        return data;
    }

///////////////////////////////////////////////////////////////////////

    @FXML
    public void dialogAddProduct(){
        TextInputDialog dialog = new TextInputDialog("Например: Сливки");
        dialog.setTitle("Добавление продукта");
        dialog.setHeaderText("Добавим продукт");
        dialog.setContentText("Введите имя продукта");

        Optional<String> result = dialog.showAndWait();
        if (result.isPresent()){
            addProductInList(result.get());
            tableData.setItems(data);
        }
    }
    @FXML
    public void deleteProductFromList(){
        int selectedIndex = tableData.getSelectionModel().getSelectedIndex();
        if (selectedIndex >= 0){
        tableData.getItems().remove(selectedIndex);}
        else {
            Alert alert = new Alert(Alert.AlertType.ERROR);
            alert.setTitle("Ошибка");
            alert.setHeaderText("Ошибка при попытки удаления");
            alert.setContentText("Список пуст или объект не выбран!");

            alert.showAndWait();
        }
    }

    void addProductInList(String nameProduct){
        data.add(new Product(nameProduct));
    }

////////////////////////////////////////////////////////////////////

    @FXML
    private void initialize() {
        nameProductColumn.setCellValueFactory(cellData -> cellData.getValue().nameProductProperty());

        showProductDetails(null);
        tableData.getSelectionModel().selectedItemProperty().addListener(
                (observable, oldValue, newValue) -> showProductDetails(newValue));
    }

    private void showProductDetails(Product product) {
        if(product != null){
        nameProd.setText(product.getNameProduct());
        quantityOfProd.setText(Double.toString(product.getQuantityOfProduct()) + " шт в наличии");
        startPriseProd.setText(Double.toString(product.getStartPriseProduct()) + " р.");
        endPriseProd.setText(Double.toString(product.getEndPriseProduct()) + " р.");
        salesProd.setText(Integer.toString(product.getSalesProduct()) + " шт.");}
        else {
            nameProd.setText("");
            quantityOfProd.setText("");
            startPriseProd.setText("");
            endPriseProd.setText("");
            salesProd.setText("");}
    }

    @FXML
    public void showEditWindow(){
        Product selectedPerson = tableData.getSelectionModel().getSelectedItem();
        if (selectedPerson != null) {
            boolean okClicked = MainActivity.showEditDialog(selectedPerson);
            if (okClicked) {
                showProductDetails(selectedPerson);
            }

        } else {
            Alert alert = new Alert(Alert.AlertType.WARNING);
            alert.initOwner(MainActivity.getPrimaryStage());
            alert.setTitle("Внимание");
            alert.setHeaderText("Продукт не выбран");
            alert.setContentText("Выберете продукт из списка, чтобы редактировать его.");

            alert.showAndWait();
        }
    }

/////////////////////////////////////////////////////////////////////////

    public File getProductFilePath() {
        Preferences prefs = Preferences.userNodeForPackage(MainActivity.class);
        String filePath = prefs.get("filePath", null);
        if (filePath != null) {
            return new File(filePath);
        } else {
            return null;
        }
    }

    public void setProductFilePath(File file) {
        Preferences prefs = Preferences.userNodeForPackage(MainActivity.class);
        if (file != null) {
            prefs.put("filePath", file.getPath());

            // Update the stage title.
            //primaryStage.setTitle("AddressApp - " + file.getName());
        } else {
            prefs.remove("filePath");

            // Update the stage title.
           // primaryStage.setTitle("AddressApp");
        }
    }

    @XmlRootElement(name = "nameProduct")
    public class DataList {

        private List<Product> products;

        @XmlElement(name = "nameProduct")
        public List<Product> getProducts() {
            return products;
        }

        public void setProducts(List<Product> products) {
            this.products = products;
        }
    }

    public void loadPersonDataFromFile(File file) {
        try {
            JAXBContext context = JAXBContext
                    .newInstance(DataList.class);
            Unmarshaller um = context.createUnmarshaller();

            // Reading XML from the file and unmarshalling.
            DataList wrapper = (DataList) um.unmarshal(file);

            data.clear();
            data.addAll(wrapper.getProducts());

            // Save the file path to the registry.
            setProductFilePath(file);

        } catch (Exception e) { // catches ANY exception

        }
    }

    public void savePersonDataToFile(File file) {
        try {
            JAXBContext context = JAXBContext
                    .newInstance(DataList.class);
            Marshaller m = context.createMarshaller();
            m.setProperty(Marshaller.JAXB_FORMATTED_OUTPUT, true);

            // Wrapping our person data.
            DataList wrapper = new DataList();
            wrapper.setProducts(data);

            // Marshalling and saving XML to the file.
            m.marshal(wrapper, file);

            // Save the file path to the registry.
            setProductFilePath(file);
        } catch (Exception e) { // catches ANY exception
            Alert alert = new Alert(Alert.AlertType.ERROR);
            alert.setTitle("Ошибка");
            alert.setHeaderText("Ошибка при попытки удаления");
            alert.setContentText("Список пуст или объект не выбран!");

            alert.showAndWait();
        }
    }

////////////////////////////////////////////////////////////////////////

    @FXML
    public void handleNew() {
        getData().clear();
        setProductFilePath(null);
    }

    @FXML
    public void handleOpen() {
        FileChooser fileChooser = new FileChooser();

        // Set extension filter
        FileChooser.ExtensionFilter extFilter = new FileChooser.ExtensionFilter(
                "XML files (*.xml)", "*.xml");
        fileChooser.getExtensionFilters().add(extFilter);

        // Show save file dialog
        File file = fileChooser.showOpenDialog(MainActivity.getPrimaryStage());

        if (file != null) {
            loadPersonDataFromFile(file);
        }
    }

    @FXML
    public void handleSave() {
        File personFile = getProductFilePath();
        if (personFile != null) {
            savePersonDataToFile(personFile);
        } else {
            handleSaveAs();
        }
    }

    @FXML
    public void handleSaveAs() {
        FileChooser fileChooser = new FileChooser();

        // Set extension filter
        FileChooser.ExtensionFilter extFilter = new FileChooser.ExtensionFilter(
                "XML files (*.xml)", "*.xml");
        fileChooser.getExtensionFilters().add(extFilter);

        // Show save file dialog
        File file = fileChooser.showSaveDialog(MainActivity.getPrimaryStage());

        if (file != null) {
            // Make sure it has the correct extension
            if (!file.getPath().endsWith(".xml")) {
                file = new File(file.getPath() + ".xml");
            }
            savePersonDataToFile(file);
        }
    }


    @FXML
    public void handleExit() {
        System.exit(0);
    }
}
