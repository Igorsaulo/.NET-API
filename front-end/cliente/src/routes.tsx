import React from 'react';
import { BrowserRouter, Route, Routes, createBrowserRouter } from 'react-router-dom';
import Home from './pages/home/home';
import Login from './pages/login/login';
import Layout from './components/layout/layout';
import ProdutoPage from './pages/produto/produtopage'
import CarAdd from './pages/caradd/caradd';
import Shoppingcar from './pages/shoppingcar/shoppingcar';
import CompraPage from './pages/compra/comprapage';


const router = createBrowserRouter([
  {
    path: '/',
    element: <Layout />,
    children: [
      {
        path: '/',
        element: <Home />,
      },
      {
        path: '/login',
        element: <Login />,
      },
      {
        path: '/produto/:id',
        element:<ProdutoPage/>,
      },
      {
        path: '/caradd',
        element:<CarAdd/>,
      },
      {
        path: '/shoppingcar',
        element:<Shoppingcar/>,
      },
      {
        path: '/compra',
        element:<CompraPage/>,
      }
    ],
  },
])

export default router;