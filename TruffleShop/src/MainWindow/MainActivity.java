package MainWindow;

import MainWindow.DataClasses.Product;
import MainWindow.EditWindow.EditController;
import javafx.application.Application;
import javafx.fxml.FXMLLoader;
import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.scene.image.Image;
import javafx.scene.layout.AnchorPane;
import javafx.stage.Modality;
import javafx.stage.Stage;

import java.io.IOException;


public class MainActivity extends Application {

    private static Stage primaryStage;

    @Override
    public void start(Stage primaryStage) throws Exception{
        this.primaryStage = primaryStage;
        Parent root = FXMLLoader.load(getClass().getResource("MainFX.fxml"));
        this.primaryStage.setTitle("Трюфель");
        this.primaryStage.getIcons().add(new Image("file:src/MainWindow/блокнот.png"));
        this.primaryStage.setScene(new Scene(root));
        this.primaryStage.show();
    }

    public static void main(String[] args) {
        launch(args);
    }

    public static boolean showEditDialog(Product product) {
        try {
            FXMLLoader loader = new FXMLLoader();
            loader.setLocation(MainActivity.class.getResource("EditWindow/EditFX.fxml"));
            AnchorPane page = (AnchorPane) loader.load();

            Stage dialogStage = new Stage();
            dialogStage.setTitle("Редактирование");
            dialogStage.initModality(Modality.WINDOW_MODAL);
            dialogStage.initOwner(primaryStage);
            Scene scene = new Scene(page);
            dialogStage.setScene(scene);

            EditController controller = loader.getController();
            controller.setDialogStage(dialogStage);
            controller.setPerson(product);

            dialogStage.showAndWait();

            return controller.isOkClicked();
        } catch (IOException e) {
            e.printStackTrace();
            return false;
        }
    }

    public static Stage getPrimaryStage() {
        return primaryStage;
    }


}
