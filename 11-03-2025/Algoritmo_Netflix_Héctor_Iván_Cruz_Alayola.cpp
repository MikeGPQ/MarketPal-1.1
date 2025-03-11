#include <iostream>
#include <vector>
#include <map>
#include <regex>
#include <limits>
#include <thread>
#include <chrono>
using namespace std;

class Usuario {
public:
    string nombre;
    string correo;
    string contrasena;
    int plan;
    string metodo_pago;
    vector<string> perfiles;

    Usuario(string nombre, string correo, string contrasena, int plan, string metodo_pago)
        : nombre(nombre), correo(correo), contrasena(contrasena), plan(plan), metodo_pago(metodo_pago) {}
};

vector<Usuario> usuarios;
map<int, string> planes = {
    {1, "Básico"},
    {2, "Estándar"},
    {3, "Premium"}
};
map<int, int> limite_perfiles = {
    {1, 1},
    {2, 3},
    {3, 5}
};
map<int, string> metodos_pago = {
    {1, "Tarjeta de Crédito/Débito"},
    {2, "PayPal"},
    {3, "Google Pay"}
};
map<int, vector<string>> contenido_por_plan = {
    {1, {"Serie A", "Película B"}},
    {2, {"Serie A", "Película B", "Serie C"}},
    {3, {"Serie A", "Película B", "Serie C", "Película D"}}
};

bool validarCorreo(const string& correo) {
    regex formatoCorreo("^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$");
    return regex_match(correo, formatoCorreo);
}

void bienvenidaNetflix() {
    cout << "====================================\n";
    cout << "        Bienvenido a Netflix \n";
    cout << "====================================\n";
    this_thread::sleep_for(chrono::seconds(1));
}

void registrarUsuario() {
    string nombre, correo, contrasena, metodo_pago;
    int plan, metodo;
    
    cout << "\n--- Registro de Usuario ---\n";
    cout << "Nombre: ";
    cin >> nombre;
    
    do {
        cout << "Correo: ";
        cin >> correo;
        if (!validarCorreo(correo)) {
            cout << "Formato de correo inválido. Intente de nuevo.\n";
        }
    } while (!validarCorreo(correo));
    
    cout << "Contraseña: ";
    cin >> contrasena;
    
    cout << "Planes disponibles:\n";
    for (const auto& plan : planes) {
        cout << plan.first << ". " << plan.second << "\n";
    }
    do {
        cout << "Seleccione su plan (1-3): ";
        cin >> plan;
    } while (planes.find(plan) == planes.end());
    
    cout << "Métodos de pago disponibles:\n";
    for (const auto& metodo : metodos_pago) {
        cout << metodo.first << ". " << metodo.second << "\n";
    }
    do {
        cout << "Seleccione su método de pago (1-3): ";
        cin >> metodo;
    } while (metodos_pago.find(metodo) == metodos_pago.end());
    
    metodo_pago = metodos_pago[metodo];
    usuarios.push_back(Usuario(nombre, correo, contrasena, plan, metodo_pago));
    cout << "Procesando pago...\n";
    this_thread::sleep_for(chrono::seconds(2));
    cout << "Pago exitoso. Registro completado.\n";
    this_thread::sleep_for(chrono::seconds(3));
}

void seleccionarContenido(Usuario& usuario, string perfil) {
    int opcion;
    do {
        cout << "\n--- Bienvenido, " << perfil << " ---\n";
        cout << "\n--- Contenido Disponible ---\n";
        for (size_t i = 0; i < contenido_por_plan[usuario.plan].size(); ++i) {
            cout << i + 1 << ". " << contenido_por_plan[usuario.plan][i] << "\n";
        }
        cout << "\nOpciones:\n";
        cout << "1. Ver contenido\n";
        cout << "2. Cerrar sesión\n";
        cout << "3. Salir del programa\n";
        cout << "Seleccione una opción: ";
        cin >> opcion;

        if (opcion == 1) {
            int seleccion;
            cout << "Seleccione el contenido que desea ver: ";
            cin >> seleccion;
            if (seleccion > 0 && seleccion <= contenido_por_plan[usuario.plan].size()) {
                cout << "Reproduciendo " << contenido_por_plan[usuario.plan][seleccion - 1] << "...\n";
                this_thread::sleep_for(chrono::seconds(2));
                int post_opcion;
                do {
                    cout << "\nOpciones:\n";
                    cout << "1. Regresar a la selección de contenido\n";
                    cout << "2. Salir del programa\n";
                    cout << "Seleccione una opción: ";
                    cin >> post_opcion;
                } while (post_opcion != 1 && post_opcion != 2);
                if (post_opcion == 2) {
                    cout << "Gracias por usar nuestro servicio. ¡Hasta luego!\n";
                    exit(0);
                }
            } else {
                cout << "Selección inválida. Intente de nuevo.\n";
            }
        } else if (opcion == 2) {
            cout << "Cerrando sesión...\n";
            return;
        } else if (opcion == 3) {
            cout << "Gracias por usar nuestro servicio. ¡Hasta luego!\n";
            exit(0);
        } else {
            cout << "Opción inválida. Intente de nuevo.\n";
        }
    } while (true);
}

void seleccionarPerfil(Usuario& usuario) {
    int opcion;
    
    while (usuario.perfiles.empty()) {
        cout << "No tienes perfiles creados. Debes crear al menos uno.\n";
        string nuevoPerfil;
        cout << "Ingrese el nombre del nuevo perfil: ";
        cin.ignore();
        getline(cin, nuevoPerfil);
        usuario.perfiles.push_back(nuevoPerfil);
        cout << "Perfil creado exitosamente.\n";
    }

    do {
        cout << "\n--- Selección de Perfil ---\n";
        for (size_t i = 0; i < usuario.perfiles.size(); ++i) {
            cout << i + 1 << ". " << usuario.perfiles[i] << "\n";
        }
        cout << usuario.perfiles.size() << "/" << limite_perfiles[usuario.plan] << " perfiles creados.\n";
        cout << "1. Seleccionar perfil\n";
        cout << "2. Crear nuevo perfil\n";
        cout << "Seleccione una opción: ";
        cin >> opcion;
        
        if (opcion == 1) {
            int seleccion;
            cout << "Seleccione un perfil: ";
            cin >> seleccion;
            if (seleccion > 0 && seleccion <= usuario.perfiles.size()) {
                cout << "Bienvenido, " << usuario.perfiles[seleccion - 1] << "!\n";
                seleccionarContenido(usuario, usuario.perfiles[seleccion - 1]);
                return;
            } else {
                cout << "Selección inválida. Intente de nuevo.\n";
            }
        } else if (opcion == 2 && usuario.perfiles.size() < limite_perfiles[usuario.plan]) {
            string nuevoPerfil;
            cout << "Ingrese el nombre del nuevo perfil: ";
            cin.ignore();
            getline(cin, nuevoPerfil);
            usuario.perfiles.push_back(nuevoPerfil);
            cout << "Perfil creado exitosamente.\n";
        } else {
            cout << "No se pueden agregar más perfiles.\n";
        }
    } while (true);
}

void iniciarSesion() {
    string correo, contrasena;
    bool encontrado = false;

    cout << "\n--- Inicio de Sesión ---\n";
    cout << "Correo: ";
    cin >> correo;

    for (Usuario& usuario : usuarios) {
        if (usuario.correo == correo) {
            encontrado = true;
            int intentos = 3;
            do {
                cout << "Contraseña: ";
                cin >> contrasena;
                if (usuario.contrasena == contrasena) {
                    cout << "Inicio de sesión exitoso. Bienvenido, " << usuario.nombre << "!\n";
                    seleccionarPerfil(usuario);
                    return;
                } else {
                    cout << "Contraseña incorrecta. Intentos restantes: " << --intentos << "\n";
                    if (intentos == 0) {
                        cout << "¿Desea recuperar su contraseña? (S/N): ";
                        char opcion;
                        cin >> opcion;
                        if (tolower(opcion) == 's') {
                            cout << "Verificación en dos pasos completada. Restablezca su contraseña.\n";
                            cout << "Nueva contraseña: ";
                            cin >> usuario.contrasena;
                            cout << "Contraseña restablecida con éxito. Inicie sesión nuevamente.\n";
                            return;
                        }
                    }
                }
            } while (intentos > 0);
        }
    }
    if (!encontrado) cout << "No se encontró una cuenta con este correo.\n";
}

void menuPrincipal() {
    int opcion;
    do {
        cout << "\n--- Menú Principal ---\n";
        cout << "1. Iniciar sesión\n";
        cout << "2. Crear cuenta\n";
        cout << "3. Salir del programa\n";
        cout << "Seleccione una opción: ";
        cin >> opcion;

        switch (opcion) {
            case 1:
                iniciarSesion();
                break;
            case 2:
                registrarUsuario();
                break;
            case 3:
                cout << "Gracias por usar Netflix. ¡Hasta la próxima!\n";
                exit(0);
            default:
                cout << "Opción inválida. Intente de nuevo.\n";
        }
    } while (true);
}

int main() {
    bienvenidaNetflix();
    menuPrincipal();

    return 0;
}