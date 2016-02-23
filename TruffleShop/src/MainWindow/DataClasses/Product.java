package MainWindow.DataClasses;

import javafx.beans.property.SimpleStringProperty;
import javafx.beans.property.StringProperty;

/**
 * Created by trefi on 10.01.2016.
 */
public class Product {

    private StringProperty nameProduct;
    private double quantityOfProduct;
    private double startPriseProduct;
    private double endPriseProduct;
    private int salesProduct;

    public Product(String nameProduct) {
        this.nameProduct = new SimpleStringProperty(nameProduct);
        this.quantityOfProduct = 0;
        this.startPriseProduct = 0;
        this.endPriseProduct = 0;
        this.salesProduct = 0;
    }

    public StringProperty nameProductProperty() {
        return nameProduct;
    }

    public String getNameProduct() {
        return nameProduct.get();
    }

    public void setNameProduct(String nameProduct) {
        this.nameProduct.set(nameProduct);
    }

    public double getQuantityOfProduct() {
        return quantityOfProduct;
    }

    public void setQuantityOfProduct(double quantityOfProduct) {
        this.quantityOfProduct = quantityOfProduct;
    }

    public double getStartPriseProduct() {
        return startPriseProduct;
    }

    public void setStartPriseProduct(double startPriseProduct) {
        this.startPriseProduct = startPriseProduct;
    }

    public double getEndPriseProduct() {
        return endPriseProduct;
    }

    public void setEndPriseProduct(double endPriseProduct) {
        this.endPriseProduct = endPriseProduct;
    }

    public int getSalesProduct() {
        return salesProduct;
    }

    public void setSalesProduct(int salesProduct) {
        this.salesProduct = salesProduct;
    }
}
