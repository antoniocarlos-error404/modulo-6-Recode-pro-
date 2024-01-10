import React from 'react';
import Link from 'next/link';
import 'bootstrap/dist/css/bootstrap.min.css';
import '@/styles/Navbar.module.css'


const Navbar = () => {
    return (
        <nav className="navbar navbar-expand-lg" style={{ background: 'white' }}>
            <div className="navbar-logo">
                <img src="images/logo-default.png" alt="Logo" style={{ height: '50px', width: 'auto', left: '50%' }} />
            </div>
            <div className='d-grid place-items-center'>
                <ul className="navbar-nav ml-auto">
                    <li className="nav-item">
                        <Link href="/">
                            <span className="nav-link">Clientes</span>
                        </Link>
                    </li>
                    <li className="nav-item">
                        <Link href="/destinos">
                            <span className="nav-link">Destinos</span>
                        </Link>
                    </li>
                    <li className="nav-item">
                        <Link href="/pedidos">
                            <span className="nav-link">Pedidos</span>
                        </Link>
                    </li>
                </ul>
            </div>
        </nav>
    );
};

export default Navbar;