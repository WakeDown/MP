package MainWindow.EditWindow;

import MainWindow.DataClasses.Product;
import javafx.fxml.FXML;
import javafx.scene.control.Alert;
import javafx.scene.control.TextField;
import javafx.stage.Stage;

/**
 * Created by trefi on 14.01.2016.
 */
public class EditController {

    @FXML
    private TextField nameProduct, quantityOfProduct, startPriseProduct, endPriseProduct, salesProduct;
    private Stage dialogStage;
    private Product product;
    private boolean okClicked = false;

    @FXML
    private void initialize() {
    }

    public void setDialogStage(Stage dialogStage) {
        this.dialogStage = dialogStage;
    }

    public boolean isOkClicked() {
        return okClicked;
    }

    public void setPerson(Product product) {
        this.product = product;

        nameProduct.setText(product.getNameProduct());
        quantityOfProduct.setText(Double.toString(product.getQuantityOfProduct()));
        startPriseProduct.setText(Double.toString(product.getStartPriseProduct()));
        endPriseProduct.setText(Double.toString(product.getEndPriseProduct()));
        salesProduct.setText(Integer.toString(product.getSalesProduct()));

    }

    @FXML
    private void handleOk() {
        if (isInputValid()) {
            product.setNameProduct(nameProduct.getText());
            product.setQuantityOfProduct(Double.parseDouble(quantityOfProduct.getText()));
            product.setStartPriseProduct(Double.parseDouble(startPriseProduct.getText()));
            product.setEndPriseProduct(Double.parseDouble(endPriseProduct.getText()));
            product.setSalesProduct(Integer.parseInt(salesProduct.getText()));

            okClicked = true;
            dialogStage.close();
        }
    }

    @FXML
    private void handleCancel() {
        dialogStage.close();
    }

    private boolean isInputValid() {
        String errorMessage = "";

        if (nameProduct.getText() == null || nameProduct.getText().length() == 0) {
            errorMessage += "Поля не должны быть пустыми!\n";
        }
        if (quantityOfProduct.getText() == null || quantityOfProduct.getText().length() == 0) {
            errorMessage += "Поля не должны быть пустыми!\n";
        } else {
            try {
                Double.parseDouble(quantityOfProduct.getText());
            } catch (NumberFormatException e) {
                errorMessage += "Одна из строк заполненна неправильно!\n";
            }
        }
        if (startPriseProduct.getText() == null || startPriseProduct.getText().length() == 0) {
            errorMessage += "Поля не должны быть пустыми!\n";
        } else {
            try {
                Double.parseDouble(startPriseProduct.getText());
            } catch (NumberFormatException e) {
                errorMessage += "Одна из строк заполненна неправильно!\n";
            }
        }

        if (endPriseProduct.getText() == null || endPriseProduct.getText().length() == 0) {
            errorMessage += "Поля не должны быть пустыми!\n";
        } else {
            try {
                Double.parseDouble(endPriseProduct.getText());
            } catch (NumberFormatException e) {
                errorMessage += "Одна из строк заполненна неправильно!\n";
            }
        }

        if (salesProduct.getText() == null || salesProduct.getText().length() == 0) {
            errorMessage += "Поля не должны быть пустыми!\n";
        } else {
            try {
                Integer.parseInt(salesProduct.getText());
            } catch (NumberFormatException e) {
                errorMessage += "Одна из строк заполненна неправильно!\n";
            }
        }


        if (errorMessage.length() == 0) {
            return true;
        } else {
            // Show the error message.
            Alert alert = new Alert(Alert.AlertType.ERROR);
            alert.initOwner(dialogStage);
            alert.setTitle("Ошибка");
            alert.setHeaderText("Проверьте правильность заполнения полей");
            alert.setContentText(errorMessage);

            alert.showAndWait();

            return false;
        }
    }
}
